using BootFlixHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BootFlixHome.Controllers
{
    public class ViewersController : Controller
    {
        // GET: Viewers
        public ActionResult Index()
        {
            var viewers = GetViewers();

            return View(viewers);
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var viewer = GetViewers().SingleOrDefault(c => c.ID == id);

            if (viewer == null)
            {
                return HttpNotFound();
            }
            return View(viewer);
        }

        private IEnumerable<Viewer> GetViewers()
        {
            return new List<Viewer>
            {
                new Viewer {ID = 1, FirstName = "Themis", LastName = "Sarigiorgis"},
                new Viewer {ID = 2, FirstName = "Stergios", LastName = "Dimas"},
                new Viewer {ID = 3, FirstName = "Mixalis", LastName = "Drakakis"},
                new Viewer {ID = 4, FirstName = "Dionisis", LastName = "Eystathopoulos"},
                new Viewer {ID = 5, FirstName = "Tatiana", LastName = "Croitor"},
                new Viewer {ID = 5, FirstName = "Maria", LastName = "Croitor"}

            };
            
        }
    }
}