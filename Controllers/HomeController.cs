using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffeehouse1.Models;

namespace Coffeehouse1.Controllers
{
    public class HomeController : Controller
    {
        CardContext db = new CardContext();
        public ActionResult Index()
        {
            IEnumerable<Card> cards = db.Cards;
            ViewBag.Cards = cards;
            return View();
        }

      
    }
}