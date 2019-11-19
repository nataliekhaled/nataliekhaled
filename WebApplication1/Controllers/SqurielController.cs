using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SqurielController : Controller
    {
        // GET: Squriel
        public ActionResult Index()
        {

            Sqirrel katherine = new Sqirrel()
            {
                Name = "Katy",
                IsBushyTail = false,
                TeethSize = 0,
                Image=@""


            }
            return View();
        }

            
            {
                return View();
            }
        }
    }
}
