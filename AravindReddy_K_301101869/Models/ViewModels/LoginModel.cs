﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [UIHint("Secret123$")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}
