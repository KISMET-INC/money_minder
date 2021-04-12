using System.ComponentModel.DataAnnotations;
using System;

namespace money_minder.Models 
{
    public class AccountBalance
    {
        [Key]
        [Required]
        public Decimal Total {get;set;}

        // TimeStamp
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}