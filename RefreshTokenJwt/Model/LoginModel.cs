﻿using System.ComponentModel.DataAnnotations;

namespace RefreshTokenJwt.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
