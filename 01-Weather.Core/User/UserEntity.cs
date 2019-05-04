﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _01_Weather.Core.User
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string family { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
