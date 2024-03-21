using Acme.BookStore.Books;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Students
{
    public class StudentAppService :
          CrudAppService<
         Student, //The Book entity
         StudentDto, //Used to show books
         Guid, //Primary key of the book entity
         PagedAndSortedResultRequestDto, //Used for paging/sorting
         CreateUpdateStudentDto>, //Used to create/update a book
     IStudentAppService //implement the IBookAppService
    {
        private readonly IRepository<Student> _studentRepository;
        public StudentAppService(IRepository<Student, Guid> repository)
            : base(repository)
        {
            _studentRepository = repository;
        }
        public override Task<StudentDto> CreateAsync(CreateUpdateStudentDto input)
        {

            input.Name = input.Name + "Speehive";

            return base.CreateAsync(input);
        }

        public override Task<StudentDto> GetAsync(Guid id)
        {
            return base.GetAsync(id);
        }

        public override Task<PagedResultDto<StudentDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetListAsync(input);
        }

        public override Task<StudentDto> UpdateAsync(Guid id, CreateUpdateStudentDto input)
        {
            return base.UpdateAsync(id, input);
        }

        public void Hello()
        {

        }
        public void CreateStudentSample(CreateUpdateStudentDto input)
        {
            //Manual Mapping
            Student stud = new Student()
            {
                Name = input.Name,
                Subject = input.Subject,
            };
            //using AutoMapper
            Student StudentEntity = ObjectMapper.Map<CreateUpdateStudentDto, Student>(input);
            _studentRepository.InsertAsync(stud);
        }
    }
}
