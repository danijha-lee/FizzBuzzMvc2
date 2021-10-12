using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMvc2.Models
{
    public class FizzBuzz
    {
        public int FizzValue { get; set; } 
        public int BuzzValue { get; set; }

        public List<string> Results { get; set; } = new List<string>();
    }
}