﻿using System.ComponentModel.DataAnnotations;

namespace T_Shirt_E_commerce.ViewModels
{
    public class RegisterViewModel
    {
        [Required] public string Username { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        [Required][DataType(DataType.Password)] public string Password { get; set; }
        [DataType(DataType.Password)][Compare("Password")] public string ConfirmPassword { get; set; }
    }
}