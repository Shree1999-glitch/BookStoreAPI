using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? Biography { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
