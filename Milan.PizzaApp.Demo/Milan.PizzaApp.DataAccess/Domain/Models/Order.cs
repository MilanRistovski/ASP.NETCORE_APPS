using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Milan.PizzaApp.Demo.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Delivered { get; set; }
        public User User { get; set; }
        public Pizza Pizza { get; set; }
    }
}
