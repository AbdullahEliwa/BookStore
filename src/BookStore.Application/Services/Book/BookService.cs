using System;
using BookStore.Dtos.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using BookNameSpace = BookStore.Entities.Books; //namespace alias, I have to do that, because I havce Book Namespace, infact we're current on it XD

namespace BookStore.Services.Book
{
    public class BookService : CrudAppService<
                                            BookNameSpace.Book,
                                            BookDto, // Used to show books
                                            Guid, // Primary key of the books entity
                                            PagedAndSortedResultRequestDto, // Used for pagination, sorting
                                            CreateBookDto, // Used to Create a book
                                            UpdateBookDto> // Used to Update a book
                                , IBookService
    {

        public BookService(IRepository<BookNameSpace.Book, Guid> bookRepository)
            : base(bookRepository)
        {
            // As u can see, We don't need to write anything, because CrudAppService already implemented it for us, nice ha.
        }

    }
}
