using System.ComponentModel.DataAnnotations;

namespace Webapplication1.Models
{
    public class Customer_description
    {
        [Key]
        public int id { get; set; }
        public int customers_id { get; set; }
        public string customers_name { get; set; }
        public string customers_occasion { get; set; }
    }
}