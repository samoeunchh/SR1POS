using System;
using System.ComponentModel.DataAnnotations;

namespace SR1POS.Models
{
    public class Unit
    {
        [Key]
        public Guid UnitId { get; set; }
        [Required]
        [Display(Name ="Unit Name")]
        [MaxLength(50)]
        public string UnitName { get; set; }
        [Required]
        public int Qty { get; set; }
    }
}
