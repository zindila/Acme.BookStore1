using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Students
{
    public class StudentDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Age { get; set; }
    }
}
