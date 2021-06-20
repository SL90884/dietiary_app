using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dietiary.Models

{   
    public enum Sex { mężczyzna, kobieta }

    public class Person
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }

        public Person()
        {
            
        }
    }
}
