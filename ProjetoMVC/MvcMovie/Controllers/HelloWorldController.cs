using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Welcome(string nome, int numTimes = 1)
        {
            ViewData["Message"] = "Ola " + nome;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
