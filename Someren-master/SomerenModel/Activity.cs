using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityNumber { get; set; } // auto incremented in SQL
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; } 
        public DateTime EndDateTime { get; set; } 

    }
}
