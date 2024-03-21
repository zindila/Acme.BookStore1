using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{

    private readonly IRepository<Book> _bookRepository;
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
            _bookRepository = repository;

    }

    public override Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {

        input.Name = input.Name + "Speehive";

        return base.CreateAsync(input);
    }

    public override Task<BookDto> GetAsync(Guid id)
    {
        return base.GetAsync(id);
    }

    public override Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return base.GetListAsync(input);
    }

    public override Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        return base.UpdateAsync(id, input);
    }

    public void Hello()
    {

    }
    public void CreateBookSample(CreateUpdateBookDto input)
    {
        //Manual Mapping
        Book book = new Book()
        {
            Name = input.Name,
            Price = input.Price,
        };
        //using AutoMapper
        Book BookEntity = ObjectMapper.Map<CreateUpdateBookDto,Book>(input);
        _bookRepository.InsertAsync(book);
    }
}

