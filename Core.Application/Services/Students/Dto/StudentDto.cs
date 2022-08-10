using Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services.Students.StudentDto
{
    public class StudentDto
    {
        protected int Id { get; set; }
        protected string? Name { get; set; }
        protected int Age { get; set; }
        protected Address? Address { get; set; }
        public int RollId { get; set; }
        public string? Class { get; set; }
        public DateTime AdmissionDate { get; set; }

    }
}
