using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace money_minder.Models
{
    public class Paycheck
    {
        [Key]
        public int PaycheckId {get; set;}
        
        [Required]
        public DateTime PayDate { get; set; }

        public string From { get; set; }

        [Required]
        public Decimal Total { get; set; }


        //Navigation Propertiy
        public List<Bill> PlannedBills {get;set;}


        // TimeStamp
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}