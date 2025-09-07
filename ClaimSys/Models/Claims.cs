using System;

namespace ClaimSys.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
