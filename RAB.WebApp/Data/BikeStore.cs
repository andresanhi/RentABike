using RAB.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAB.WebApp.Data
{
    public class BikeStore
    {
        private List<Bike> Bikes { get; set; } = new List<Bike>();
        public BikeStore()
        {
            Bikes.Add(new Bike
            {
                IdBike = Guid.NewGuid(),
                Brand = "GW",
                Reference = "Lynx",
                Type = "Montaña,",
                Size = "M,L",
                Color = "Gris",
                Frame = "Aluminio",
                Tires = "MTB Labrado Mixto - 29X2.10 F158 KYLIN NEGRA",
                Seat = "GW MTB",
                Brakes = "Disco mecánico",
                Pedals = "MTB",
                Speeds = 22,
                Rin = 25,
                Handle = "MTB en Aluminio",
                Image = "Gw Lynx.JPG",
                Quantity = 2,
                Available =2,
                PriceHour = 10000
            });

            Bikes.Add(new Bike
            {
                IdBike = Guid.NewGuid(),
                Brand = "Fusion",
                Reference = "Korbin",
                Type = "Montaña,",
                Size = "L,XL",
                Color = "Amarillo",
                Frame = "Aluminio",
                Tires = "MTB agarre todo tipo de terreno",
                Seat = "MTB FUSION",
                Brakes = "Disco mecánico",
                Pedals = "MTB",
                Speeds = 24,
                Rin = 29,
                Handle = "MTB FUSION en Aluminio",
                Image = "Fusion Korbin.JPG",
                Quantity = 2,
                Available = 2,
                PriceHour = 10000
            });

        }

        public List<Bike> GetBikes()
        {
            return this.Bikes;
        }
    }
}
