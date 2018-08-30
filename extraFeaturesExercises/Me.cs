using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraFeaturesExercises
{
    public class Me
    {
        public Me(string first) : this(29, first) { }

        
        public Me(int years, string first)
        {
            age = years;
            fName = first;
            Id = Guid.NewGuid();
        }
            public int age { get; set; }
            public string fName { get; set; }
            public Guid Id { get; set; }
    }
}
