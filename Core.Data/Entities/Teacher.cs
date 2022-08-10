using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Entities
{
    [Index(nameof(CNIC), IsUnique = true)]
   public class Teacher : Person
    {

        [MaxLength(13), Required]
        public string? CNIC { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfJoin { get; set; }
        
    }

   
}
