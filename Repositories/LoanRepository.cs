

using LoanApi.Data;
using LoanApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanApi.Repositories
{
    public class LoanRepository
    {
        private readonly LoanDbContext _context;

        public LoanRepository(LoanDbContext context)
        {
            _context = context;
        }

        public async Task<List<Loan>> GetLoans()
        {
            return await _context.Loans
                .Include(l => l.Customer)
                .ToListAsync();
        }

        public async Task<Loan> AddLoan(Loan loan)
        {
            _context.Loans.Add(loan);

            await _context.SaveChangesAsync();

            return loan;
        }
    }
}