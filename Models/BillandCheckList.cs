using System.Collections.Generic;



namespace money_minder.Models {
    public class BillandCheckList {
        public List<Bill> BillsList {get;set;}
        public List<Paycheck> CheckList {get; set;}
    }
}