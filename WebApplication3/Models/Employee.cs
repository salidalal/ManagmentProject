﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThisAbility.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Key]
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "User Name must be 3 to 15 characters")]
        public string UserName { get; set; }


        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Password must be 3 to 15 characters")]
        public string Password { get; set; }


    }
}