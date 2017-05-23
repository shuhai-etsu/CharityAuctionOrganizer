using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication9.Models
{
    public class Payment
    {
        [Key]
        public int Payment_ID { get; set; }
        public string Payment_Type { get; set; }
        public DateTime Date { get; set; }
        public Bidder Bidder { get; set; }
    }
}