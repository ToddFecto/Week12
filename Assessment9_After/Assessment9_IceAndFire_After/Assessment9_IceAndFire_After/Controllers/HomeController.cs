using Assessment9_IceAndFire_After.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Assessment9_IceAndFire_After.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var character1 = await DAL.GetCharacterById(1303);
            var character2 = await DAL.GetCharacterById(583);
            var character3 = await DAL.GetCharacterById(1346);
            var character4 = await DAL.GetCharacterById(1052);
            var character5 = await DAL.GetCharacterById(16);
            var character6 = await DAL.GetCharacterById(1340);
            var character7 = await DAL.GetCharacterById(2126);
            var character8 = await DAL.GetCharacterById(1709);
            var character9 = await DAL.GetCharacterById(957);
            var character10 = await DAL.GetCharacterById(743);
            var character11 = await DAL.GetCharacterById(1523);
            var character12 = await DAL.GetCharacterById(1787);
            var character13 = await DAL.GetCharacterById(2041);
            var character14 = await DAL.GetCharacterById(1427);
            var character15 = await DAL.GetCharacterById(1938);
            var character16 = await DAL.GetCharacterById(364);
            var character17 = await DAL.GetCharacterById(1768);
            var character18 = await DAL.GetCharacterById(937);
            var character19 = await DAL.GetCharacterById(1766);
            var character20 = await DAL.GetCharacterById(775);
            var character21 = await DAL.GetCharacterById(238);
            var character22 = await DAL.GetCharacterById(148);
            var character23 = await DAL.GetCharacterById(325);
            var character24 = await DAL.GetCharacterById(814);
            var character25 = await DAL.GetCharacterById(1541);
            var character26 = await DAL.GetCharacterById(379);
            var character27 = await DAL.GetCharacterById(671);
            var character28 = await DAL.GetCharacterById(557);
            var character29 = await DAL.GetCharacterById(832);
            var character30 = await DAL.GetCharacterById(418);

            List<Character> listofCharacters = new List<Character>
            {
                character1,
                character2,
                character3,
                character4,
                character5,
                character6,
                character7,
                character8,
                character9,
                character10,
                character11,
                character12,
                character13,
                character14,
                character15,
                character16,
                character17,
                character18,
                character19,
                character20,
                character21,
                character22,
                character23,
                character24,
                character25,
                character26,
                character27,
                character28,
                character29,
                character30
            };

            return View(listofCharacters);
        }

        public IActionResult Privacy()
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
