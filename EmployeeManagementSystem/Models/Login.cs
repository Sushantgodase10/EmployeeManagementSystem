﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeMSService.Models
{
    public class Login
    {
        [Key]
       public int Id { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
