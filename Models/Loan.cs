
using  System.Text.Json.Serialization;
namespace LoanApi.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public double Amount { get; set; }

        public int CustomerId { get; set; }
        [JsonIgnore]
        public Customer? Customer { get; set; }
    }
}
