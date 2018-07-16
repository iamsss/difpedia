using System.ComponentModel.DataAnnotations;

namespace difpediaProject.Models
{
    public class Difference
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
    }
}