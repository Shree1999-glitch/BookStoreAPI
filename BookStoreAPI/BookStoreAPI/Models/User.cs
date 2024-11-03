﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }  // Will store hashed password

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? Role { get; set; } = "User";  // Default role
    }
}
