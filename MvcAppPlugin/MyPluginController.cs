using Microsoft.AspNetCore.Mvc;

namespace MvcAppPlugin
{
    public class MyPluginController : Controller
    {
        public IActionResult Index() => View();
    }
}
