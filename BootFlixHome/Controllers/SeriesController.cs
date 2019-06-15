using BootFlixHome.Models;
using BootFlixHome.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootFlixHome.Controllers
{
    public class SeriesController : Controller
    {
        // GET: Series/Favourite
        public ActionResult Favourite()
        {
            var serie = new Serie()
            {
                Name = "Breaking Bad"
            };

            var viewers = new List<Viewer>
            {
                new Viewer {FirstName = "Themis", LastName = "Sarigiorgis"},
                new Viewer {FirstName = "Stergios", LastName = "Dimas"},
                new Viewer {FirstName = "Mixalis", LastName = "Drakakis"}
            };


            var favouriteViewModel = new FavouriteViewModel()
            {
                Serie = serie,
                Viewers = viewers
            };

            return View(favouriteViewModel);
        }

        // GET: Series/Edit
        public ActionResult Edit(int? id)
        {
            var something = ("The ID is : " + id);
            return Content(something);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Date";
            }
            return Content(string.Format("pageIndex= {0} & sortBy {1}", pageIndex, sortBy));
        }

        [Route("Series/Released/{year}/{month}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/ * " + month);
        }

        

        
    }


}