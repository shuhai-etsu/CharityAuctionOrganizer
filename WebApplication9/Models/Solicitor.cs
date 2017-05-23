using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication9.Models
{
    public class Solicitor
    {
        [Key]
        public int Solicitor_ID { get; set; }
        public string Solicitor_Name { get; set; }
    }
}