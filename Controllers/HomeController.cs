﻿using System;
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Gods()
        {
            return View();
        }

        public IActionResult Items()
        {
            return View();
        }

        public IActionResult PlayerSummary(string playerToSearch)
        {
            ApiCall.CreateSession();
            Smite.previousName = playerToSearch;
            Smite.player = ApiCall.GetPlayerInfo(playerToSearch);
            Smite.playerGodRanks = ApiCall.GetGodRanks(playerToSearch);
            Smite.playerMatchHistory = ApiCall.GetMatchHistory(playerToSearch);
            Smite.playerRankedConquest = ApiCall.GetPlayerQueueStats(playerToSearch, "504");

            return View();
        }

        public IActionResult Ranked()
        {
            return View();
        }

        public IActionResult MatchHistory()
        {
            return View();
        }

        public IActionResult GodRanks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
