using System.ComponentModel.DataAnnotations;

namespace A1.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        public string UserComment { get; set; }

        public String IP { get; set; }

        public String Time { get; set; }

        
    }
}