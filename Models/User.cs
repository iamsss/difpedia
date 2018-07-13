using System;
using System.ComponentModel.DataAnnotations;

namespace difpediaProject.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Password { get; set; }

        public int ReferalUserId { get; set; }
        public int Balance { get; set; }
        public DateTime? AddedOn  { get; set; }
    }
}