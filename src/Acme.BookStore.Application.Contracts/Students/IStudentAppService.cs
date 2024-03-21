using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace Acme.BookStore.Students
{
   public interface IStudentAppService :
    ICrudAppService< //Defines CRUD methods
        StudentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStudentDto>
    {

    }
}
