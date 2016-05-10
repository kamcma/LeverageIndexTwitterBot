using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Threading;

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

                            Console.Write("{0:t}: Game state changed. Leverage Index is {1}\n", DateTime.Now, game.LeverageIndex);

                            if (game.LeverageIndex >= 1.5)
                            {
                                try
                                {
                                    string tweetContent = PhraseGenerator(game.CurrentBatter, game.BaseState, game.Inning, game.HomeRuns - game.AwayRuns);
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
                    }
                    Thread.Sleep(20 * 1000);
                }
                while (game.Status != "Final");
                Console.WriteLine(game.GameID + " over");
            }
            Console.WriteLine("Program ending");
        }

        static void Tweet(string tweetText)
        {
            string consumerKey = "pCmsnFypeb6E4kV5MTGUqBTKR";
            string consumerSecret = "6apuAiOUTvFAeify3OQhKZ7dtccngVTVVYcGMHl8qiALhO4SRC";
            TwitterService service = new TwitterService(consumerKey, consumerSecret);

            string token = "727610217467289600-sFSKObp8ObrnWQHzGlDaqFixmMzXw2X";
            string tokenSecret = "bc60OTgVCmYblFbAkMBI4QgsMDIjmiMDJ3WkXoO7LUGFl";
            service.AuthenticateWith(token, tokenSecret);

            SendTweetOptions tweet = new SendTweetOptions();
            tweet.Status = tweetText;
            service.SendTweet(tweet);
        }

        static string PhraseGenerator(string batter, Tuple<bool, bool, bool> baseState, Tuple<bool, int, int> inning, int runDeltaHome)
        {
            string basesPhrase = "";
            if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                basesPhrase = "nobody on";
            if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                basesPhrase = "a man on first";
            if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                basesPhrase = "a man on second";
            if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                basesPhrase = "a man on third";
            if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                basesPhrase = "men on first and second";
            if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                basesPhrase = "men on the corners";
            if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                basesPhrase = "men on second and third";
            if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                basesPhrase = "the bases loaded";

            string differentialPhrase = "";
            if (runDeltaHome == 0)
            {
                differentialPhrase = "tied";
            }
            else if (runDeltaHome > 0)
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
            
            return "Heads up: @Indians " + differentialPhrase + " and " + batter + "up with " + basesPhrase + " and " + outsPhrase + " is a high-leverage situation.";
        }
    }
}
