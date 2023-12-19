using System.ComponentModel.DataAnnotations;
namespace VidlyApplication.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
