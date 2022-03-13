using AutoMapper;
using BookStore.Dtos.Books;
using BookStore.Entities.Books;

namespace BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


        //TODO: Move mapping into sperated class, folder... find a better solution.

        #region Book Entity Mapping
        CreateMap<Book, BookDto>();
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
        #endregion


    }
}
