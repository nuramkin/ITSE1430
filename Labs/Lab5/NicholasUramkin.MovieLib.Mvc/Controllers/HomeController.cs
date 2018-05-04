/* Nicholas Uramkin
 * Lab 5
 * ITSE 1430
 * 4/30/2018
 * HomeController.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NicholasUramkin.MovieLib.Mvc.Controllers
{
    /// <summary>
    /// Controller class for homepage
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Result of Index action
        /// </summary>
        /// <returns>ViewResult</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}