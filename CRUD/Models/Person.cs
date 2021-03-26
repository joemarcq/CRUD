using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage="Firstname is required!")]
        public String Firstname { get; set; }
        [Required]
        public String Lastname { get; set; }
        [Required]
        public String MI { get; set; }
        [Required]
        public String EmailAddress { get; set; }

        [Required]
        public String Address { get; set; }
        [Required, Range(16, 99)]
        public int Age { get; set; }
        [Required]
        public String Contact { get; set; }

    }
}
