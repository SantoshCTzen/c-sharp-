using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_App.Controllers
{
    public class CatagoryController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index");
        }
    }


 



}
