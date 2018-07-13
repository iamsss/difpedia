using System;
using System.ComponentModel.DataAnnotations;

namespace difpediaProject.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Role { get; set; }
        [Required]
        public string password { get; set; }

        public int referalUserId { get; set; }
        public int balance { get; set; }
        public DateTime AddedOn  { get; set; }
    }
}