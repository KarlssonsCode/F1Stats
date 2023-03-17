using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Stats.Models
{


    public class Constructors
    {
        public MrdataConstructors MRData { get; set; }
    }

    public class MrdataConstructors
    {
        public string xmlns { get; set; }
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string total { get; set; }
        public Constructortable ConstructorTable { get; set; }
    }

    public class Constructortable
    {
        public string season { get; set; }
        public Constructor[] Constructors { get; set; }
    }

    public class Constructor
    {
        public string constructorId { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
    }


}
