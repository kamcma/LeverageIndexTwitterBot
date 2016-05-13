using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cleLI
{
    partial class Game
    {
        private string gameID;
        public string GameID
        {
            get
            {
                return this.gameID;
            }
        }
        private DateTime date;
        private string gamedayURL;
        public string GamedayURL
        {
            get
            {
                return this.gamedayURL;
            }
        }
        public bool WatchingHome { get; set; }
        public string Status { get; set; }
        public Tuple<bool, int, int> Inning { get; set; }
        public int AwayRuns { get; set; }
        public int HomeRuns { get; set; }
        public Tuple<bool, bool, bool> BaseState { get; set; }
        public string CurrentBatter { get; set; }
        public string CurrentPitcher { get; set; }

        public double LeverageIndex { get; set; }

        public Game (string gameID)
        {
            this.gameID = gameID;
            this.date = Gameday.AdjustBaseballDay(DateTime.Now).Date;
            this.gamedayURL = Gameday.GamedayBaseURL(DateTime.Now) + gameID;
            this.Inning = new Tuple<bool, int, int>(true, 1, 0);
            this.AwayRuns = 0;
            this.HomeRuns = 0;
            this.BaseState = new Tuple<bool, bool, bool>(false, false, false);
            this.LeverageIndex = 0.9;
            this.WatchingHome = this.GameID.IndexOf("cle") <= 20 ? false : true;
        }

        public bool Refresh()
        {
            try
            {
                XmlDocument gamedayData = new XmlDocument();
                gamedayData.Load(gamedayURL + "/miniscoreboard.xml");

                
                this.Status = gamedayData.SelectSingleNode("/game/game_status").Attributes.GetNamedItem("status").Value;

                this.HomeRuns = Convert.ToInt32(gamedayData.SelectSingleNode("/game/linescore/r").Attributes.GetNamedItem("home").Value);
                this.AwayRuns = Convert.ToInt32(gamedayData.SelectSingleNode("/game/linescore/r").Attributes.GetNamedItem("away").Value);

                int outNumber = Convert.ToInt32(gamedayData.SelectSingleNode("/game/game_status").Attributes.GetNamedItem("o").Value);
                int inningNumber = Convert.ToInt32(gamedayData.SelectSingleNode("/game/game_status").Attributes.GetNamedItem("inning").Value);
                string topInningAsString = gamedayData.SelectSingleNode("/game/game_status").Attributes.GetNamedItem("top_inning").Value;
                bool topInningAsBool = false;
                if (topInningAsString == "Y" || topInningAsString == "T")
                {
                    topInningAsBool = true;
                }
                this.Inning = new Tuple<bool, int, int>(topInningAsBool, inningNumber, outNumber);

                string b1 = gamedayData.SelectSingleNode("/game/in_game/runner_on_1b").Attributes.GetNamedItem("id").Value;
                string b2 = gamedayData.SelectSingleNode("/game/in_game/runner_on_2b").Attributes.GetNamedItem("id").Value;
                string b3 = gamedayData.SelectSingleNode("/game/in_game/runner_on_3b").Attributes.GetNamedItem("id").Value;
                this.BaseState = new Tuple<bool, bool, bool>(b1 == "" ? false : true, b2 == "" ? false : true, b3 == "" ? false : true);

                this.CurrentBatter = gamedayData.SelectSingleNode("/game/in_game/batter").Attributes.GetNamedItem("last").Value;
                this.CurrentPitcher = gamedayData.SelectSingleNode("/game/in_game/pitcher").Attributes.GetNamedItem("last").Value;

                this.LeverageIndex = BaseballStat.LeverageIndex(this.Inning, this.BaseState, this.HomeRuns - this.AwayRuns);

                return true;
            }
            catch
            {
                Console.WriteLine("Update failed for {0}", this.GameID);
                return false;
            }
        }
        
    }
}
