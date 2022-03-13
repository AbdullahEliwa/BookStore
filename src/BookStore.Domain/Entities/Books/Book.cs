using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStore.Entities.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishedDate { get; set; }
        public float Price { get; set; }



    }
}
