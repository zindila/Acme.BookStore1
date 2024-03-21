using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Students
{
   public class CreateUpdateStudentDto
    {
        [Required]
    [StringLength(128)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Subject { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
