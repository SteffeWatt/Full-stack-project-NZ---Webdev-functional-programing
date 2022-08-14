using System.ComponentModel.DataAnnotations;


namespace A1.Dtos
{
    public class CommentDto
    {
        
        public string? Name { get; set; }
        [Required]
        public string UserComment { get; set; }
        
    }
}