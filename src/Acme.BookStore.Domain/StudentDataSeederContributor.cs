using Acme.BookStore.Students;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;


namespace Acme.BookStore
{
    public class StudentDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Student, Guid> _studentRepository;

        public StudentDataSeederContributor(IRepository<Student, Guid> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _studentRepository.GetCountAsync() <= 0)
            {
                await _studentRepository.InsertAsync(
                    new Student
                    {
                        Name = "Cindila",
                        Subject = "Csharp",
                        Age = 22

                    },
                    autoSave: true
                );


            }
        }
    }
}
