﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Auction
    {
        [Key]
        public int Auction_ID { get; set; }
        public string Auction_Name { get; set; }
        public string Auction_Type { get; set; }
        public DateTime Auction_Date { get; set; }
        public TimeSpan Start_Time { get; set; }
        public TimeSpan Close_Time { get; set; }
        public string Auction_Location { get; set; }

    }
}