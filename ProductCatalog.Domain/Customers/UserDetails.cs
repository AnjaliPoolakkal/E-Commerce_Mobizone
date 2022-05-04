using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class UserDetails
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }


        [Column("FirstName", Order = 1, TypeName = "Varchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName", Order = 2, TypeName = "Varchar(50)")]
        [Required]
        public string LastName { get; set; }

        [Column("Email", Order = 3, TypeName = "Varchar(100)")]
        [Required]
        public string Email { get; set; }

        [Column("Contact", Order = 4, TypeName = "bigInt")]
        [Required]
        public long Contact { get; set; }

        [Column("Address", Order = 5, TypeName = "varchar(500)")]
        [Required]
        public string Address { get; set; }

        

        


    }
}
