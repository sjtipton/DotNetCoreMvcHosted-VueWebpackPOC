using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMvcHosted_VueWebpackPOC.Models;

namespace DotNetCoreMvcHosted_VueWebpackPOC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = ".NET Core MVC Hosted Vue.js Webpack Template";

            ViewBag.Message = "This is rendered from the .NET Core MVC action";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
