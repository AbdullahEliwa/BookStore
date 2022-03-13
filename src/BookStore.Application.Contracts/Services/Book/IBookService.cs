using BookStore.Dtos.Books;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BookStore.Services.Book
{
    //Note: Of course [ICrudAppService] have only standard normal operations like: getAll, get, create, update, delete
    // So, If u want more specific operations, Add them here.
    public interface IBookService : ICrudAppService< // Defines CRUD methods
                                                    BookDto, // Used to show books
                                                    Guid, // Primary key of the books entity
                                                    PagedAndSortedResultRequestDto, // Used for pagination, sorting
                                                    CreateBookDto, // Used to Create a book
                                                    UpdateBookDto> // Used to Update a book
    {

    }

}
