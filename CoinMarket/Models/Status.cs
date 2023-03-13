using System.ComponentModel.DataAnnotations;

namespace CoinMarket.Models
{
    public class Status
    {
        public DateTime? timestamp { get; set; }
        public int? error_code { get; set; }
        public string? error_message { get; set; }
        public int elapsed { get; set; }
        public int credit_count { get; set; }
        public string? notice { get; set; }
        public int total_count { get; set; }
    }
}
