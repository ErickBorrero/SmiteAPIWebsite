using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmiteAPIWebsite
{
    public class Smite
    {
        public static string previousName = "";
        public static List<PlayerInfo> player;
        public static List<GodRanks> playerGodRanks;
        public static List<MatchHistory> playerMatchHistory;
        public static List<MatchDetails> matchDetails;
        public static List<PlayerQueueStats> playerRankedConquest;

        public static List<Gods> gods = ApiCall.GetGodsInfo();

        public static List<ItemsInfo> items = ApiCall.GetItems();

        public static Dictionary<string, Gods> godsDictionary = ApiCall.GetGodsInfo().ToDictionary(god => god.Name, god => god, StringComparer.OrdinalIgnoreCase);

        public static Dictionary<string, ItemsInfo> itemsDictionary = ApiCall.GetItems().GroupBy(i => i.DeviceName).ToDictionary(item => item.Key, item => item.First(), StringComparer.OrdinalIgnoreCase);

    }
}
