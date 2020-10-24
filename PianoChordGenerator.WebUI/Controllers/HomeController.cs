using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PianoChordGenerator.Domain.Data;
using PianoChordGenerator.Domain.Logic;
using PianoChordGenerator.Domain.Enums;
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
            var data = new List<KeyValuePair<string, string>>(list.GetData());

            foreach (KeyValuePair<string, string> kvp in data)
                {
                chord = new SelectListItem
                {
                    Text = kvp.Value,
                    Value = kvp.Key
                };
                chordsList.Add(chord);                    
                }
          

            ViewBag.ChordList = chordsList;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult GenerateChordSheet([FromBody] JSONModel data)
        {            
            try
            {
                var chordList = new List<string>(JsonConvert.DeserializeObject<List<string>>(data.Json));
                var logic = new Logic();
                string svgXml;

                svgXml = logic.GeneratePianoChartSvgXml(chordList);

                return Json(svgXml);
              
                
            } catch 
            {
                //return Json("Something went wrong generating chord chart. Please try again."); 
                return Json("Failed");
            }
                        
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
