using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Poker.Tests.Controllers
{
    public class PokerController : Controller
    {
        public ActionResult Poker()
        {
            ViewBag.Message = "poker.";

            return View();
        }
    }
}
