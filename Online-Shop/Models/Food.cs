﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shop.Models
{
    public partial class Food
    {
        public Food()
        {
            FoodIngredient = new HashSet<FoodIngredient>();
            FoodOrder = new HashSet<FoodOrder>();

            Ingredients = new List<Ingredient>();
        }

        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }

        [NotMapped]
        public List<Ingredient> Ingredients { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<FoodIngredient> FoodIngredient { get; set; }
        public virtual ICollection<FoodOrder> FoodOrder { get; set; }
    }
}
