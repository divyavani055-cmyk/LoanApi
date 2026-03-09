using System.Text.Json.Serialization;

namespace LoanApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [JsonIgnore]
        public List<Loan> Loans { get; set; }

    }
}
