using System;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Entities.Models
{
    public class CustomerOrder : IdentityBase
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Address { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string City { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string State { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Country { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public Decimal Amount { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string CustomerUserName { get; set; }
    }
}