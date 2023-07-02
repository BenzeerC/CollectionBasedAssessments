using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBasedAssessments
{//WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop.

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[5] { 11, 22, 33, 44, 55 };
            Console.WriteLine("-------Integer Arrays Are----------");

            foreach (int item in MyArray) 
            {
                Console.WriteLine(item);
            }

        }
    }
}
