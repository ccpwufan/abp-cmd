using AutoMapper;
using AbpCMD.Entities.Books;
using AbpCMD.Services.Dtos.Books;

namespace AbpCMD.ObjectMapping;

public class AbpCMDAutoMapperProfile : Profile
{
    public AbpCMDAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
        /* Create your AutoMapper object mappings here */
    }
}
