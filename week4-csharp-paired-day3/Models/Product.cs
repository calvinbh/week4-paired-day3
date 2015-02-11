using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week4_csharp_paired_day3.Models
{
    public abstract class Product
    {
        public string Title { get; set; }
        public string CreatedBy {get; set;}
        //public DateTime {get; set;}
        public string City {get; set;}
        public string State {get; set;}

    }


}