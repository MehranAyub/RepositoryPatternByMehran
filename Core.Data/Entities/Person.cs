using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Entities
{
    abstract public class Person
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public  string? Name { get; set; }
        public int Age { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address? Address { get; set; }
        public int AddressId { get; set; }
    }
}
