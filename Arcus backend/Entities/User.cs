using System.ComponentModel.DataAnnotations.Schema;

namespace Arcus.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? RegisteredAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? ImagePath { get; set; }
        public string? About { get; set; }
    }
}
