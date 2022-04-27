using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class UserLocation
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("City", Order = 1)]
        [Required]
        public string City { get; set; }

        [Column("PostalCode", Order = 2)]
        [Required]
        public string PostalCode { get; set; }

        [Column("Country", Order = 3)]
        [Required]
        public string Country { get; set; }

        
    }
}
