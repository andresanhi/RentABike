using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAB.WebApp.Models
{
    public class Bike
    {
        public Guid IdBike { get; set; }
        public string Reference { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Frame { get; set; }
        public string Tires { get; set; }
        public string Seat { get; set; }
        public string Brakes { get; set; }
        public string Pedals { get; set; }
        public int Speeds { get; set; }
        public int Rin { get; set; }
        public string Handle { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Available { get; set; }
        public double PriceHour { get; set; }
    }
}
