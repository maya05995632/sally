using System;
using System.Collections.Generic;
using System.Text;

namespace sally.models
{
     public class patient
    
    {
        [key] 
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}

