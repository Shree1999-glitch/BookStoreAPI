using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? ISBN { get; set; }

        public DateTime? PublishedDate { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public int AuthorId { get; set; }

        public Author? Author { get; set; }
    }
}
