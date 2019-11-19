using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Class1
    {
        public string Name { get; set; }
        public int TeethSize {get; set;}
        public string Image { get; set; }
        public bool IsBushyTail { get; set; }
        
        public Class1()
        {
            Name = string.Empty;
            TeethSize = 0;
            Image = "";
            IsBushyTail = false;

        }
    }
}