using BookStore.Entities.Books;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace BookStore.Seeding
{
    //Side Note: I don't like to seed my data like this, better approach to use migrations!
    //Run DbMigrator Project after finishing to apply the migration(that's add books table), and seeding data,
    // Instead of typing: [update-database]
    public class BookSeeder : IDataSeedContributor, ITransientDependency
    {
        public readonly IRepository<Book, Guid> _bookRepository;
        public BookSeeder(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertManyAsync(new List<Book>
                {
                    new Book
                    {
                        Name = "1948",
                        Type = BookType.Horror,
                        PublishedDate = new DateTime(1949, 6, 8),
                        Price = 20.5f
                    }, // Remember it's just a demo XD
                    new Book
                    {
                        Name = "Harry Potter",
                        Type = BookType.Fantastic,
                        PublishedDate = new DateTime(1995, 9, 27),
                        Price = 40.5f
                    }
                }, autoSave: true); // Used to automatically save change to DB.
            }
        }
    }
}
