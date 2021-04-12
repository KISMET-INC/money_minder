using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace money_minder.Models 
{
    public class Bill
    {
        [Key]

        [Required]
        public Decimal Total {get;set;}

        [Required]
        public string Type {get;set;}

        public string Company {get;set;}

        public string Url {get;set;}

        [Required]
        public DateTime Due {get;set;}

        //Navigation Property
        public List<BillHistory> Histories {get;set;}


        // Navigation Property
        public int CheckId {get;set;}
        public Check PlannedFrom {get;set;}


        // TimeStamp
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }

}