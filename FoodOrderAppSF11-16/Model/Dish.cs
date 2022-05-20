using FoodOrderAppSF11_16.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderAppSF11_16.Model
{
    public class Dish
    {

        public int ID { get; set; }


        [MaxLength(70)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [MaxLength(120)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;

        [Required]
        public DishTypeEnum DishType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<DailyMenu> DailyMenus { get; set; }

    }
}
