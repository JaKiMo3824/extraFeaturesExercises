using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace extraFeaturesExercises
{
    class Program

    {
        static void Main(string[] args)
        {
            

            

            var newMe = new Me("Jacob");

            const string welcome = "Hello, ";
            Console.WriteLine(welcome + newMe.fName + "! Your new ID# is " + newMe.Id + ".");
            Console.ReadLine();


        }

        

    }
}
