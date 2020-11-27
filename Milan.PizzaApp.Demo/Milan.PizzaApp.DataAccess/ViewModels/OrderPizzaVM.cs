using System;
using System.Collections.Generic;
using System.Text;

namespace Milan.PizzaApp.DataAccess.ViewModels
{
    public class OrderPizzaVM
    {
        public bool Delivered { get; set; }
        public UserVM User { get; set; }
        public PizzaVM Pizza { get; set; }
    }
}
