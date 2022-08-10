using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Entities
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id
        {
            get;
            set;
        }
        [Required]
        public string? StreetAdress
        {
            get;
            set;
        }
        [Required]
        public string? City
        {
            get;
            set;
        }
        public string? State
        {
            get;
            set;
        }
        public string? ZipCode
        {
            get;
            set;
        }
        
       
    }
}
