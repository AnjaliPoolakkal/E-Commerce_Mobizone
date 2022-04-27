using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Role
{
    public class Roles
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("Roles", Order = 1)]
        [Required]
        public string UserRole { get; set; }

        [Column("UserId", Order = 2)]
        [Required]
        public int UserId { get; set; }
        public virtual Customers.User User { get; set; }

        [Column("CreatedDateUtc", Order = 3)]
        public DateTime CreatedAtUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 4)]
        public DateTime ModifiedAtUTC { get; set; }

        [Column("CreatedBy", Order = 5)]
        public DateTime CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 6)]
        public DateTime ModifiedBy { get; set; }



       
        
    }
}
