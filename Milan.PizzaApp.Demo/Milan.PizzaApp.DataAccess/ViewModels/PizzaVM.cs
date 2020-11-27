using Milan.PizzaApp.Demo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Milan.PizzaApp.DataAccess.ViewModels
{
    public class PizzaVM
    {
        public int Id { get; set; }
        [Display(Name = "Pizza Name")]
        public string Name { get; set; }
        [Display(Name = "PizzaSize")]
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}