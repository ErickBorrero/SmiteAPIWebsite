using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmiteAPIWebsite
{
    public class Smite
    {
        [StringLength(15)]
        public static string previousName = "";

        public static bool isActive;

        public static List<PlayerInfo> player;

        public static List<GodRanks> playerGodRanks;

        public static List<MatchHistory> playerMatchHistory;

        public static List<MatchDetails> matchDetails;

        public static List<PlayerQueueStats> playerRankedConquest;

        public static List<Gods> gods;

        public static List<ItemsInfo> items;

        public static Dictionary<string, Gods> godsDictionary;

        public static Dictionary<string, ItemsInfo> itemsDictionary;

        public static string CheckResult(MatchHistory match)
        {
            if(match.Win_Status == "Loss")
            {
                return "table-danger";
            }

            return "table-success";
        }

        public static void TestServer()
        {
            isActive = ApiCall.TestSession();

            if (!isActive)
            {
                ApiCall.CreateSession();
            }
        }
    }
}
