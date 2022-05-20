using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderAppSF11_16.Model
{
    public class DailyMenu
    {
        public int ID { get; set; }

        [Required]
        public DayOfWeek Day { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;

        public WeeklyMenu WeeklyMenu{ get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
