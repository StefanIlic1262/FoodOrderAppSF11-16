using FoodOrderAppSF11_16.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderAppSF11_16.Model
{
    public class User
    {
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(50)]
        [Required]
        public string Email { get; set; } = string.Empty;

        [MaxLength(50)]
        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public bool IsChosenOne { get; set; } = false;

        [Required]
        public bool IsDeleted { get; set; } = false;

        [Required]
        public UserTypeEnum UserType{ get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
