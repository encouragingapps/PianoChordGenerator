using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PianoChordGenerator.Domain.Data;
using PianoChordGenerator.WebUI.Models;

namespace PianoChordGenerator.WebUI.Controllers
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
            List<SelectListItem> chordsList = new List<SelectListItem>();
            SelectListItem chord;
            ChordDataList list = new ChordDataList();
            var data = new List<KeyValuePair<string, string>>();

            data = list.GetData();

            foreach (KeyValuePair<string, string> kvp in data)
                {
                    chord = new SelectListItem();
                    chord.Text = kvp.Value;
                    chord.Value = kvp.Key;
                    chordsList.Add(chord);                    
                }
          

            ViewBag.ChordList = chordsList;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public JsonResult GenerateChordSheet([FromBody] JSONModel data)
        {
            var s = data;
            return Json("OK");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
