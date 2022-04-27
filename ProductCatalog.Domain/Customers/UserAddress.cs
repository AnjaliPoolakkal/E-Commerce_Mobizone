using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class UserAddress
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("UserId", Order = 1)]
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Column("AddressLine", Order = 2)]
        [Required]
        public string AddressLine { get; set; }

        [Column("Contact", Order = 3)]
        [Required]
        public int Contact { get; set; }

        [Column("UserLocationId", Order = 4)]
        [Required]
        public int UserLocationId { get; set; }
        public virtual UserLocation UserLocation { get; set; }

        
    }
}
