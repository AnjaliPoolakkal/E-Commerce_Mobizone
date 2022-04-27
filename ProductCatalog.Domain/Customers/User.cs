using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class User
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("UserName", Order = 1)]
        [Required]
        public string UserName { get; set; }

        [Column("Password", Order = 2)]
        [Required]
        public string Password { get; set; }

        [Column("FirstName", Order = 3, TypeName = "Varchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName", Order = 4, TypeName = "Varchar(50)")]
        [Required]
        public string LastName { get; set; }

        [Column("Email", Order = 5, TypeName = "Varchar(100)")]
        [Required]
        public string Email { get; set; }

        [Column("Contact", Order = 6, TypeName = "bigInt")]
        [Required]
        public long Contact { get; set; }

        [Column("CreatedDateUtc", Order = 7)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 8)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("CreatedBy", Order = 9)]
        [Required]
        public string CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 10)]
        [Required]
        public string ModifiedBy { get; set; }

        
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<Cart.CartItem> CartItems { get; set; }
        public virtual ICollection<Order.OrderDetails> OrderDetails { get; set; }
    }
}
