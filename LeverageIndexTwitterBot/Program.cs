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
                if (game.Refresh())
                {
                    while (game.Status != "Final")
                    {
                        if (game.Refresh())
                        {
                            //Console.Write("{0:t}: Leverage Index is {1}\n", DateTime.Now, game.LeverageIndex);
                        }
                        else
                        {
                            Console.WriteLine("{0:t}: Refresh failed\n", DateTime.Now.TimeOfDay);
                        }
                        Thread.Sleep(30 * 1000);
                    }
                    Console.WriteLine("Game over.");
                }
                else
                {
                    Console.WriteLine("specified xml file for {0} not found\n{1}", game.GameID, game.GamedayURL);
                }
            }


            //Test LeverageIndex()
            //Console.WriteLine(BaseballStat.LeverageIndex(new Tuple<bool, int, int>(false, 3, 2), new Tuple<bool, bool, bool>(false, true, false), -1));


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
    }
}
