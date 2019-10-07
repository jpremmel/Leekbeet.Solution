using Microsoft.AspNetCore.Mvc;
using Leekbeet.Models;

namespace Leekbeet.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index() { return View(); }
       
        [Route("/output")]
        public ActionResult Output(string input)
        {
            LeekbeetTranslator newLeekbeet = new LeekbeetTranslator();
            newLeekbeet.Input = input;
            newLeekbeet.Output = "";
            newLeekbeet.Translate(newLeekbeet);
            return View(newLeekbeet);
        }
    }
}