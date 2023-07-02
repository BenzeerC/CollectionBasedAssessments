using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBasedAssessments
{
    //WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.

    internal class Program2
    {
        static void Main(string[] args)
        {
            string[] StudentNames = new string [5] {"Rahul","Arsh","Sangeeta","Bobby","Chetan" };
            Console.WriteLine("---Before Sorting-----");
            Array.Sort(StudentNames);
            Console.WriteLine("--------After Sorting----------");
            foreach (string StudentName in StudentNames)
            {
                Console.WriteLine(StudentName);
            }

        }
    }
}
