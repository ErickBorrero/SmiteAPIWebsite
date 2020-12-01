using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmiteAPIWebsite
{
    public class Smite
    {
        public static List<Gods> gods = ApiCall.GetGodsInfo();

        public static List<ItemsInfo> items = ApiCall.GetItems();

        public static Dictionary<string, Gods> godsDictionary = ApiCall.GetGodsInfo().ToDictionary(god => god.Name, god => god);

        /*public static Dictionary<string, ItemsInfo> itemsDictionary = ApiCall.GetItems().ToDictionary(item => item.DeviceName, item => item);*/

    }
}
