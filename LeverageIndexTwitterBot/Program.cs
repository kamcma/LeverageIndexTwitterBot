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
        static void Main(string[] args)
        {
            List<string> todaysGameIDs = Gameday.GetGameIDs(DateTime.Now, "cle");
            List<Game> todaysGames = new List<Game>();

            foreach (string gameID in todaysGameIDs)
            {
                todaysGames.Add(new Game(gameID));
            }

            foreach (Game game in todaysGames)
            {
                Console.WriteLine(game.GameID + "\n");
                Console.Write("{0:t}: Game to start. Leverage Index is {1}\n", DateTime.Now, game.LeverageIndex);
                //Tuple<Tuple<bool, int, int>, Tuple<bool, bool, bool>, int> lastKnownGameState = new Tuple<Tuple<bool, int, int>, Tuple<bool, bool, bool>, int>(new Tuple<bool, int, int>(true, 1, 0), new Tuple<bool, bool, bool>(false, false, false), 0);
                int lastKnownOuts = 0;
                bool lastKnownFirstStatus = false;
                bool lastKnownSecondStatus = false;
                bool lastKnownThirdStatus = false;
                int lastKnownRunDeltaHome = 0;

                do
                {
                    if (game.Refresh())
                    {
                        if (!(game.Inning.Item3 == lastKnownOuts && game.BaseState.Item1 == lastKnownFirstStatus && game.BaseState.Item2 == lastKnownSecondStatus && game.BaseState.Item3 == lastKnownThirdStatus && game.HomeRuns - game.AwayRuns == lastKnownRunDeltaHome))
                        {
                            //Game state changed
                            Thread.Sleep(2 * 1000);
                            game.Refresh();
                            Console.Write("{0:t}: Game state changed. H:{2} A:{3}, {4}o. 1B:{5} 2B:{6} 3B:{7} -- LI: {1}\n", DateTime.Now, game.LeverageIndex, game.HomeRuns, game.AwayRuns, game.Inning.Item3, game.BaseState.Item1, game.BaseState.Item2, game.BaseState.Item3);

                            if (game.LeverageIndex >= 3.0)
                            {
                                try
                                {
                                    string tweetContent = PhraseGenerator(game.CurrentBatter, game.BaseState, game.Inning, game.WatchingHome, game.HomeRuns - game.AwayRuns, game.LeverageIndex);
                                    Tweet(tweetContent);
                                    Console.WriteLine("Tweeted: " + tweetContent);
                                }
                                catch
                                {
                                    Console.WriteLine("Tweet failed");
                                }
                            }

                            lastKnownOuts = game.Inning.Item3;
                            lastKnownFirstStatus = game.BaseState.Item1;
                            lastKnownSecondStatus = game.BaseState.Item2;
                            lastKnownThirdStatus = game.BaseState.Item3;
                            lastKnownRunDeltaHome = game.HomeRuns - game.AwayRuns;
                            
                        }
                        Thread.Sleep(25 * 1000);
                    }
                    else
                    {
                        Thread.Sleep(60 * 1000);
                    }
                    
                }
                while (game.Status != "Final");
                Console.WriteLine(game.GameID + " over");
            }
            Console.WriteLine("Program ending");

            //Tweet("Test");
            //Console.WriteLine("tweeted");
        }

        static void Tweet(string tweetText)
        {
            string consumerKey = ConfigurationManager.AppSettings["consumerKey"];
            string consumerSecret = ConfigurationManager.AppSettings["consumerSecret"];
            TwitterService service = new TwitterService(consumerKey, consumerSecret);

            string token = ConfigurationManager.AppSettings["token"];
            string tokenSecret = ConfigurationManager.AppSettings["tokenSecret"];
            service.AuthenticateWith(token, tokenSecret);

            SendTweetOptions tweet = new SendTweetOptions();
            tweet.Status = tweetText;
            service.SendTweet(tweet);
        }

        static string PhraseGenerator(string batter, Tuple<bool, bool, bool> baseState, Tuple<bool, int, int> inning, bool watchingHome, int runDeltaHome, double leverageIndex)
        {
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
            // Heads up: the Indians up one bot 6 with a runner on 1B, one out is a high-leverage (1.6) situation.
            return "Heads up: Indians " + differentialPhrase + (inning.Item1 ? " top " : " bottom ") + inningNumberString + " with " + basesPhrase + " and " + outsPhrase + " is a very-high-leverage (" + leverageIndex + ") situation.";
        }
    }
}
