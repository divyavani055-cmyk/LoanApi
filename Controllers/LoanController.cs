using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoanApi.Models;
using LoanApi.Data;
using Microsoft.EntityFrameworkCore;
using LoanApi.Repositories;

namespace LoanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly LoanRepository _loanRepository;

        public LoanController(LoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        [HttpGet]

        public async Task<IActionResult> GetLoans()
        {
            var loans = await _loanRepository.GetLoans();
            return Ok(loans);
        }

        //[HttpPost]

        //public async Task<IActionResult> AddLoan(Loan loan)
        //{
        //    _context.Loans.Add(loan);
        //    await _context.SaveChangesAsync();
        //    return Ok(loan);
        //}

        [HttpPost]
        public async Task<ActionResult<Loan>> PostLoan(Loan loan)
        {
            var result = await _loanRepository.AddLoan(loan);
            return Ok(result);
        }


        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateLoan(int id, Loan loan)
        //{
        //    var existingLoan = await _context.Loans.FindAsync(id);
        //    if (existingLoan == null)
        //    {
        //        return NotFound();
        //    }
        //    existingLoan.Type = loan.Type;
        //    existingLoan.Amount = loan.Amount;
        //    await _context.SaveChangesAsync();
        //    return Ok(existingLoan);
        //}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLoan(int id)
        //{
        //    var existingLoan = await _context.Loans.FindAsync(id);
        //    if (existingLoan == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Loans.Remove(existingLoan);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
        //public IActionResult GetLoans()
        //{
        //    var laons = new List<Loan>
        //    {

        //        new Loan {Id =1, Type= "Home Loan", Amount= 50000},
        //        new Loan {Id =2, Type= "Car Loan", Amount= 100000}
        //    //{
        //    //    "Home Loan",
        //    //    "Car Loan",
        //    //    "Personal Loan"

        //    };

        //    return Ok(laons);
        //}
    }
}
