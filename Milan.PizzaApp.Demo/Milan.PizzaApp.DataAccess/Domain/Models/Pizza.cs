using Milan.PizzaApp.Demo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Milan.PizzaApp.Demo.Models
{
    public class Pizza
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public Discount Discount { get; set; }

    }
}
