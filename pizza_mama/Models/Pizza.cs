﻿using System.ComponentModel.DataAnnotations;

namespace pizza_mama.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        [Display(Name = "Nom")]
        public string nom { get ; set; }
        [Display(Name = "Prix ($)")]
        public float prix { get; set; }
        [Display (Name = "Végétarienne")]
        public bool vegetarienne {  get; set; }
        public string ingredients { get; set; } 
    }
}
