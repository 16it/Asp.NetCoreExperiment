using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore_WebPage.Controllers
{
    /// <summary>
    /// Vue����
    /// </summary>
    public class VueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// ����ȡ����
        /// </summary>
        /// <returns></returns>
        [HttpGet("students")]
        public JsonResult Students()
        {
            return new JsonResult(new List<dynamic>() { new { ID = 1, Name = "����" }, new { ID = 2, Name = "����" } }, new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}