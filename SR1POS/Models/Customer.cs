using System;
using System.ComponentModel.DataAnnotations;

namespace SR1POS.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        [MaxLength(15)]
        [Phone]
        public string Mobile { get; set; }
        [MaxLength(100)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
