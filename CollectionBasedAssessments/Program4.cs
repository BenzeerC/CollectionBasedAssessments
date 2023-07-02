using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBasedAssessments
{//WAP to create jagged array, initialized data & display the details

    internal class Program4
    {
        static void Main(string[] args)
        {
            int[][] MyArray = new int[3][];
            
                MyArray[0] =new[]{ 11,22,33,44,55,66};
                MyArray[1] =new[]{ 111,222,333,444,555,666};
                MyArray[2] =new[]{ 1111,2222,3333,4444};

            foreach(int[] items in MyArray)
            {
                foreach(int item in items)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
