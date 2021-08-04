using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() 
        {
             return View();
            //return View("../../Tempview/arview");
            //return View("~/Tempview/arview.cshtml");  // to find view from different location
        }

        public ViewResult AboutUs()
        {
            return View();
        }

    }
}
