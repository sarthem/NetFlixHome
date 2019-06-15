using BootFlixHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootFlixHome.ViewModels
{
    public class FavouriteViewModel
    {
        public Serie Serie { get; set; }
        public List<Viewer> Viewers { get; set; }
    }
}