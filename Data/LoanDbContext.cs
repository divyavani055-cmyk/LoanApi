using Microsoft.EntityFrameworkCore;
using LoanApi.Models;



namespace LoanApi.Data
{
    public class LoanDbContext : DbContext
    {
        public LoanDbContext(DbContextOptions<LoanDbContext> options) : base(options)
        {
        }
        public DbSet<Loan> Loans { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
