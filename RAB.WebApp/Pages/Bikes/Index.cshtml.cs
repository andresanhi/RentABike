using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RAB.WebApp.Data;
using RAB.WebApp.Models;

namespace RAB.WebApp.Pages.Bikes
{
    public class IndexModel : PageModel
    {
        public BikeStore BikeStore{ get; set; }
        public List<Bike> Bikes { get; set; }
        public IndexModel(BikeStore bikeStore)
        {
            BikeStore = bikeStore;
            Bikes = BikeStore.GetBikes();
        }
        public void OnGet()
        {
        }
    }
}