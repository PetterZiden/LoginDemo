﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models.ViewModels
{
    public class AccountLoginVM
    {
        [Required(ErrorMessage = "Enter a username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
