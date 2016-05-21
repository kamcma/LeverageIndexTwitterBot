using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Threading;
using System.Configuration;

namespace cleLI
{
    class Program
    {
        // Created by team @cleLeverageBot for the Tribe Hackathon 2016
        

        static void Main(string[] args)
        {
            // infinite loop!
            while (true)
            {
                // if any unhandled exception occurs, jump down to the catch block
                try
                {
                    //grab the current EDT
                    DateTime currentET = DateTime.UtcNow.AddHours(-4);
                    Console.WriteLine(currentET);

                    //using the current EDT and a team abbreviation, return a list of today's games of that team (usually one, but two in case of double header)
                    List<string> todaysGameIDs = Gameday.GetGameIDs(currentET, "cle");

                    //Foreach GamedID, instantiate a game object and add it to a list of today's game objects
                    List<Game> todaysGames = new List<Game>();
                    foreach (string gameID in todaysGameIDs)
                    {
                        todaysGames.Add(new Game(gameID, currentET));
                    }

                    //foreach game object in the list of today's games
                    foreach (Game game in todaysGames)
                    {
                        Console.WriteLine(game.GameID);
                        Console.Write("{0:t}: Game to start. Leverage Index is {1}\n", DateTime.Now, game.LeverageIndex);
                        //Tuple<Tuple<bool, int, int>, Tuple<bool, bool, bool>, int> lastKnownGameState = new Tuple<Tuple<bool, int, int>, Tuple<bool, bool, bool>, int>(new Tuple<bool, int, int>(true, 1, 0), new Tuple<bool, bool, bool>(false, false, false), 0);

                        //initialize a set of last known game state variables to compare against to watch for changes in the game state
                        int lastKnownOuts = 0;
                        bool lastKnownFirstStatus = false;
                        bool lastKnownSecondStatus = false;
                        bool lastKnownThirdStatus = false;
                        int lastKnownRunDeltaHome = 0;
                        string lastKnownBatter = "";

                        //run a while loop until the game is over
                        while (game.Status != "Final")
                        {
                            //try to refresh the game from the gameday api, if refresh succeeds will return true and enter if block
                            if (game.Refresh())
                            {
                                //check if game object game state properties are different than the last known game state variables
                                if (game.CurrentBatter != lastKnownBatter)
                                {
                                    //The game state has changed...

                                    //Pause two seconds and refresh again in case we caught a half-updated xml file or something
                                    //Thread.Sleep(2 * 1000);
                                    //game.Refresh();

                                    //Print the updated game state to the console for dev observatoin
                                    Console.Write("{0:t}: Game state changed. H:{2} A:{3}, {4}o. 1B:{5} 2B:{6} 3B:{7} -- LI: {1}\n", DateTime.UtcNow.AddHours(-4), game.LeverageIndex, game.HomeRuns, game.AwayRuns, game.Inning.Item3, game.BaseState.Item1, game.BaseState.Item2, game.BaseState.Item3);

                                    //Check if the game state's leverage index meets a certain threshold
                                    if ((game.LeverageIndex >= 1.5 && game.Inning.Item2 <= 3) || game.LeverageIndex >= 2.0)
                                    {
                                        //if it does, try to tweet the game state and leverage index
                                        try
                                        {
                                            //pass the current game state properties into the phraseGenerator method to return a string for tweeting
                                            string tweetContent = PhraseGenerator(game.CurrentBatter, game.CurrentPitcher, game.BaseState, game.Inning, game.WatchingHome, game.HomeRuns - game.AwayRuns, game.LeverageIndex);
                                            //pass string to tweet method, and print to console to confirm
                                            Tweet(tweetContent);
                                            Console.WriteLine("Tweeted: " + tweetContent);
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Tweet failed");
                                        }
                                    }

                                    //TODO: log all game states for a post-game summary tweet, writing to file, use on a website, etc.

                                    //update all the last known game state variables from the refreshed game state
                                    lastKnownOuts = game.Inning.Item3;
                                    lastKnownFirstStatus = game.BaseState.Item1;
                                    lastKnownSecondStatus = game.BaseState.Item2;
                                    lastKnownThirdStatus = game.BaseState.Item3;
                                    lastKnownRunDeltaHome = game.HomeRuns - game.AwayRuns;
                                    lastKnownBatter = game.CurrentBatter;

                                }
                                //Pause 25 seconds after every game refresh
                                Thread.Sleep(25 * 1000);
                            }
                            else
                            {
                                //if a refresh fails, pause for two minutes (in case, say, gameday api is briefly down or connection is bad)
                                Thread.Sleep(120 * 1000);
                            }

                        }
                        //When the game status changes to final, exit the game's while loop and print game over to the console
                        Console.WriteLine(game.GameID + " over");
                    }

                    //After a day's game(s) is(are) complete, sleep the thread for a length of time before tomorrow's games
                    int pauseHours = 4;
                    Console.WriteLine("Pausing execution for {0} hours", pauseHours);
                    Thread.Sleep(pauseHours * 60 * 60 * 1000);
                }
                // if unhandled exception occurs, wait 60 seconds before jumping back up to the top of the infinite loop
                catch
                {
                    Thread.Sleep(60*1000);
                }
            }
     
        }

        static void Tweet(string tweetText)
        {
            //retrieve the twitter api keys and tokens from the AppSettings file
            string consumerKey = ConfigurationManager.AppSettings["consumerKey"];
            string consumerSecret = ConfigurationManager.AppSettings["consumerSecret"];

            string token = ConfigurationManager.AppSettings["token"];
            string tokenSecret = ConfigurationManager.AppSettings["tokenSecret"];

            //Using TweetSharp library, instantiate and authenticate the Twitter service object
            TwitterService service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(token, tokenSecret);

            //instantiate a tweet, assign the tweetText parameter to it, and pass the tweet to the TwitterService send method
            SendTweetOptions tweet = new SendTweetOptions();
            tweet.Status = tweetText;
            service.SendTweet(tweet);
        }

        static string PhraseGenerator(string batter, string pitcher, Tuple<bool, bool, bool> baseState, Tuple<bool, int, int> inning, bool watchingHome, int runDeltaHome, double leverageIndex)
        {
            //Generate an english phrase to represent the baseState tuple
            string basesPhrase = "";
            if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                basesPhrase = "nobody on";
            if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                basesPhrase = "a runner on first";
            if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                basesPhrase = "a runner on second";
            if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                basesPhrase = "a runner on third";
            if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                basesPhrase = "runners on first and second";
            if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                basesPhrase = "runners on the corners";
            if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                basesPhrase = "runners on second and third";
            if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                basesPhrase = "the bases loaded";

            //Generate an english phrase to represent the run delta from the perspective of the watched team
            string differentialPhrase = "";
            if (runDeltaHome == 0)
            {
                differentialPhrase = "tied";
            }
            else if ((runDeltaHome > 0 && watchingHome) || (runDeltaHome < 0 && !watchingHome))
            {
                switch (Math.Abs(runDeltaHome))
                {
                    case 1:
                        differentialPhrase = "up one";
                        break;
                    case 2:
                        differentialPhrase = "up two";
                        break;
                    case 3:
                        differentialPhrase = "up three";
                        break;
                    case 4:
                        differentialPhrase = "up four";
                        break;
                    default:
                        differentialPhrase = "up > four";
                        break;
                }
            }
            else
            {
                switch (Math.Abs(runDeltaHome))
                {
                    case 1:
                        differentialPhrase = "down one";
                        break;
                    case 2:
                        differentialPhrase = "down two";
                        break;
                    case 3:
                        differentialPhrase = "down three";
                        break;
                    case 4:
                        differentialPhrase = "down four";
                        break;
                    default:
                        differentialPhrase = "down > four";
                        break;
                }
            }

            string outsPhrase = "";
            switch (inning.Item3)
            {
                case 0:
                    outsPhrase = "no outs";
                    break;
                case 1:
                    outsPhrase = "one out";
                    break;
                case 2:
                    outsPhrase = "two outs";
                    break;
                default:
                    outsPhrase = "three outs";
                    break;
            }

            string inningNumberString = "";
            switch (inning.Item2)
            {
                case 1:
                    inningNumberString = "one";
                    break;
                case 2:
                    inningNumberString = "two";
                    break;
                case 3:
                    inningNumberString = "three";
                    break;
                case 4:
                    inningNumberString = "four";
                    break;
                case 5:
                    inningNumberString = "five";
                    break;
                case 6:
                    inningNumberString = "six";
                    break;
                case 7:
                    inningNumberString = "seven";
                    break;
                case 8:
                    inningNumberString = "eight";
                    break;
                case 9:
                    inningNumberString = "nine";
                    break;
                default:
                    inningNumberString = inning.Item2.ToString();
                    break;
            }

            // Phrase scratch:
            // Heads up: Lindor facing Price right now is high-leverage (3.8) situation. #tribehackathon
            //return "Heads up: Indians " + differentialPhrase + (inning.Item1 ? " top " : " bottom ") + inningNumberString + " with " + basesPhrase + " and " + outsPhrase + " is a " + (leverageIndex >= 3.0 ? "very " : "") + "high-leverage (" + leverageIndex + ") situation.";
            return "Heads up: " + batter + " facing " + pitcher + " right now is a " + (leverageIndex >= 3.0 ? "very " : "") + "high-leverage (" + leverageIndex + ") situation. #tribehackathon";
        }
    }
}
