using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraFeaturesExercises
{
    public class Me
    {
        public Me(string first, string last) : this(29, first, last) { }


        public int age { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public Guid Id {get;set;}

        public Me(int years, string first, string last)
        {
            age = years;
            first = fName;
            last = lName;
            var newId = Guid.NewGuid();
        }

    }
}
