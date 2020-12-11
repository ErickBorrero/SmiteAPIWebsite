using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmiteAPIWebsite.Models;

namespace SmiteAPIWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Smite.TestServer();
            return View();
        }

        public IActionResult Privacy()
        {
            Smite.TestServer();
            return View();
        }

        public IActionResult Gods()
        {
            Smite.TestServer();
            return View();
        }

        public IActionResult Items()
        {
            Smite.TestServer();
            return View();
        }

        public IActionResult PlayerSummary(string playerToSearch)
        {
            Smite.TestServer();
            Smite.previousName = playerToSearch;
            Smite.player = ApiCall.GetPlayerInfo(playerToSearch);
            Smite.playerGodRanks = ApiCall.GetGodRanks(playerToSearch);
            Smite.playerMatchHistory = ApiCall.GetMatchHistory(playerToSearch);
            Smite.playerRankedConquest = ApiCall.GetPlayerQueueStats(playerToSearch, "504");

            return View();
        }

        public IActionResult Ranked()
        {
            Smite.TestServer();
            return View();
        }

        public IActionResult MatchHistory()
        {
            Smite.TestServer();
            return View();
        }

        public IActionResult GodRanks()
        {
            Smite.TestServer();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
