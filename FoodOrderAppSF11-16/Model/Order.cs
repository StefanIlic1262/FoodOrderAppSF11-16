using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderAppSF11_16.Model
{
    public class Order
    {
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalPrice { get; set; }

        public User User { get; set; }

        public DailyMenu DailyMenu { get; set; }

        public Store Store { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
