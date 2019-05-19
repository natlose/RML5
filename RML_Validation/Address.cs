using System;
using System.Collections.Generic;
using System.Text;

namespace RML_Validation
{

    public class Address
    {
        public int Id { get; set; }        
        public string Kind { get; set; } 
        public string Country3166 { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }

        public int FI_Person { get; set; }
        public Person Person { get; set; }
    }
}
