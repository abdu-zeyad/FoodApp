using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string Chef { get; set; }
    }
}