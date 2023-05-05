using System.ComponentModel.DataAnnotations.Schema;

namespace Arcus.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Meta { get; set; }
        public string? Context { get; set; }
    }
}
