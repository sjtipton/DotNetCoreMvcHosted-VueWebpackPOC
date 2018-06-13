using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcHosted_VueWebpackPOC.Controllers
{
  [Produces("application/json")]
  public class TodosController : Controller
  {
    // GET api/FakeTodos
    [HttpGet]
    [Route("~api/FakeTodos")]
    public JsonResult GetFakeTodos()
    {
      var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "todos.json");

      return Json(path);
    }
  }
}
