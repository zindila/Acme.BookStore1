using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Students
{
    public class Student:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

       // public BookType Type { get; set; }

       // public DateTime PublishDate { get; set; }

        public string  Subject { get; set; }
        public int Age { get; set; }
    }
}
