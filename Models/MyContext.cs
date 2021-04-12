using Microsoft.EntityFrameworkCore;
namespace money_minder.Models
{ 

    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillHistory> BillHistories {get; set;}
        public DbSet<AccountBalance> AccountBalances {get;set;}
    }
}
