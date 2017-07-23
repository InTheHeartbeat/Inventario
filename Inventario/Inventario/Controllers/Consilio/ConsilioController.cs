using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventario.Base.Enums;
using Inventario.Models;

namespace Inventario.Controllers.Consilio
{
    public class ConsilioController : Controller
    {
        // GET: Consilio
        public ActionResult Index()
        {
            return View(new BaseModel() {CurrentProject = ProjectName.Consilio});
        }
    }
}