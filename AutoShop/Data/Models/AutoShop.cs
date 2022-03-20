using System;
using System.Collections.Generic;

namespace AutoShop1.Models
{
    public  class AutoShop
    {
        public AutoShop()
        {

        }
        public int IdCar { get; set; }
        
        public string CarName { get; set; }
        public string Manifacture { get; set; }
        public string CarLocation { get; set; }
        public string CarPower { get; set; }
        public string CarTransmission { get; set; }
        public string CarColor { get; set; }
        public string CarPrice { get; set; }
    }
}
