using BookStore.Entities.Books;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Dtos.Books
{
    // Note: That's a very simple validation, In real life scenarios
    // We need to add localization to validation messages, more validation cases ... etc.
    // Maybe using a better validation library like fluent validation.
    public class UpdateBookDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; }

        [Required]
        public DateTime PublishedDate { get; set; }

        [Required]
        public float Price { get; set; }
    }
}
