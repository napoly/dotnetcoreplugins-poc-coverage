using Microsoft.AspNetCore.Mvc;

namespace MvcAppPlugin
{
    public class MyPluginController : Controller
    {
        public IActionResult Index()
        {
            int result = 2 + 2;
            ViewData["CalculationResult"] = result;
            return View();
        }
    }
}
