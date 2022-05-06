using ProductCatalog.Domain.Products;
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
        [Required(ErrorMessage = "Please Enter  FirstName")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "This field should not contain any numbers or special characters")]
        public string FirstName { get; set; }

        [Column("LastName", Order = 2, TypeName = "Varchar(50)")]
        [Required(ErrorMessage = "Please Enter  LastName")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "This field should not contain any numbers or special characters")]
        public string LastName { get; set; }

        [Column("Email", Order = 3, TypeName = "Varchar(100)")]
        [Required(ErrorMessage = "Please Enter  valid Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z\s]+\.[a-zA-Z\s.]+$", ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }

        [Column("Contact", Order = 4, TypeName = "bigInt")]
        [Required(ErrorMessage = "Please Enter  Contact Number")]
        [RegularExpression(@"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)")]
        public long Contact { get; set; }

        [Column("Address", Order = 5, TypeName = "varchar(500)")]
        [Required(ErrorMessage = "Please Enter  Address")]
        public string Address { get; set; }

        [Column("UserDetailsId", Order = 6)]
        [ForeignKey("UserDetail")]
        public int UserDetailsId { get; set; }
        public User UserDetail { get; set; }





    }
}
