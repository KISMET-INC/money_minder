using System.ComponentModel.DataAnnotations;
using System;


namespace money_minder.Models
{
    public class BillHistory
    {
        [Key]
        
        [Required]
        public Decimal Total {get;set;}

        [Required]
        public DateTime PaidDate {get;set;}

        //Navigation Property
        public int BillId {get;set;}
        public Bill Source {get;set;}


        // TimeStamp
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}