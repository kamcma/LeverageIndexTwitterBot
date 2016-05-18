using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cleLI
{
    public static class Gameday
    {

        public static List<string> GetGameIDs(DateTime day, string teamCode)
        {
            //day = AdjustBaseballDay(day);
            teamCode += "mlb";

            string dayDirectory;
            using (WebClient myClient = new WebClient())
            {
                dayDirectory = myClient.DownloadString(Gameday.GamedayBaseURL(day));
            }

            List<string> allGameURLs = new List<string>();

            while (dayDirectory.Contains(" gid"))
            {
                allGameURLs.Add(dayDirectory.Substring(dayDirectory.IndexOf(" gid") + 1, 30));
                dayDirectory = dayDirectory.Remove(dayDirectory.IndexOf(" gid") + 1, 30);
            }

            List<string> teamGameIDs = new List<string>();

            foreach (string url in allGameURLs)
            {

                if (url.Contains(teamCode))
                {
                    teamGameIDs.Add(url);
                }
            }

            return teamGameIDs;
        }

        public static string GamedayBaseURL(DateTime day)
        {
            //day = AdjustBaseballDay(day);
            StringBuilder url = new StringBuilder();
            url.Append("http://gd2.mlb.com/components/game/mlb/year_");
            url.Append(day.Year);
            url.Append("/month_");
            if (day.Month < 10)
            {
                url.Append("0");
            }
            url.Append(day.Month);
            url.Append("/day_");
            if (day.Day < 10)
            {
                url.Append("0");
            }
            url.Append(day.Day);
            url.Append("/");
            
            return url.ToString();
        }

        public static DateTime AdjustBaseballDay(DateTime day)
        {
            TimeZoneInfo easternTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime nycTime = TimeZoneInfo.ConvertTime(day, easternTimeZone);
            if (nycTime.Hour < 10)
            {
                day = day.AddDays(-1);
            }
            return day;
        }
    }
}
