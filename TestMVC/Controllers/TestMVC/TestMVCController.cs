using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers.TestMVC
{
    public class TestMVCController : Controller
    {
        // GET: TestMVC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveTestMVC (TestMVCModel model)
        {
            try
            {
                return Json (new {msg = (new )})
            }
        }
    }
}