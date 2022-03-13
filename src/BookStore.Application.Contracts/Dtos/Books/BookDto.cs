using BookStore.Entities.Books;
using System;
using Volo.Abp.Application.Dtos;

namespace BookStore.Dtos.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishedDate { get; set; }
        public float Price { get; set; }
    }
}
