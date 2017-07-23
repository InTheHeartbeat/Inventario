using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventario.Base.Enums;
using Inventario.Filters;
using Inventario.Models;

namespace Inventario.Controllers
{
    [Culture]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new BaseModel() {CurrentProject = ProjectName.Home});
        }  
    }
}