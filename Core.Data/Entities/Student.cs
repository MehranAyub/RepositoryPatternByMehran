using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Entities
{
    public class Student : Person
    {

        [Required]
        public int RollId { get; set; }
        public string? Class { get; set; }
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }


    }
}
