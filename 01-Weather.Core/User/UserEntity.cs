using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _01_Weather.Core.User
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string family { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
        public DateTime Bod { get; set; }
        [MaxLength(10)]
        public string BodPersion { get; set; }
        [MaxLength(11)]
        public string Mobile { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Command { get; set; }
        [MaxLength(50)]
        public string FavoritesCity { get; set; }
    }
}
