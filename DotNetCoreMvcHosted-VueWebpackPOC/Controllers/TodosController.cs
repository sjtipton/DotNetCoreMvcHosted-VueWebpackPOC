using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;

namespace DotNetCoreMvcHosted_VueWebpackPOC.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  public class TodosController : Controller
  {
    private readonly IHostingEnvironment _hostingEnvironment;

    public TodosController(IHostingEnvironment hostingEnvironment)
    {
      _hostingEnvironment = hostingEnvironment;
    }

    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Continue reading A Storm of Swords", "Nerd out on r/freefolk", "Learn Dothraki" };
    }

    // GET api/FakeTodos
    [HttpGet]
    [Route("faketodos")]
    public IActionResult GetFakeTodos()
    {
      var contentRootPath = _hostingEnvironment.ContentRootPath;
      var path = Path.Combine(contentRootPath, "Data", "todos.json");
      return PhysicalFile(path, "application/json");
    }
  }
}
