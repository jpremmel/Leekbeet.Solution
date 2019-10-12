using Microsoft.AspNetCore.Mvc;
using Leekbeet.Models;

namespace Leekbeet.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        { 
            return View(); 
        }
       
        [Route("/output")]
        public ActionResult Output(string input)
        {
            ActionResult result;
            if (string.IsNullOrEmpty(input))
            {
                result = RedirectToAction("Index");
            }
            else
            {
                LeekbeetTranslator.Input = input;
                LeekbeetTranslator.Output = "";
                LeekbeetTranslator.Translate();
                result = View();
            }
            return result;
        }

        [HttpGet("/translate")]
        public ActionResult Translate()
        {
            return View();
        }

        [HttpGet("/garlic")]
        public ActionResult Garlic()
        {
            return View();
        }
    }
}