using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore5WebApp.Core.Entities
{
    [Table("Persons", Schema = "dbo")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
