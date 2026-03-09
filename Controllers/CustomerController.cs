using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoanApi.Models;
using LoanApi.Data;
using Microsoft.EntityFrameworkCore;


namespace LoanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly LoanDbContext _context;
        public CustomerController(LoanDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(await _context.Customers.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return Ok(customer);
        }
    }
}