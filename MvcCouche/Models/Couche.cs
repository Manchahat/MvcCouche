using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcCouche.Models
{
    public class Couche
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public string Weight { get; set; }
        public string Design { get; set; }
        public string CountryOfOrigin { get; set; }



    }
}
