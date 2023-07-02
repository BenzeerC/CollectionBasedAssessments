using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBasedAssessments
{
    //WAP to store rain fall in a week using 1D array , accept & display the rain fall.

    internal class Program5
    {
        static void Main(string[] args)
        {
            double[] ArrayRainFall = new double[7];
            Console.WriteLine("'''''''''''Rainfall a day data'''''''''");

            for (int i = 0; i < ArrayRainFall.Length; i++)
            {

                Console.Write($" Enter RainFall for a day {i + 1}: ");
                ArrayRainFall[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("''''''Rainfall a week''''''''''");
            for (int i = 0; i < ArrayRainFall.Length; i++)
            {
                Console.WriteLine($"Day {i+1}: {ArrayRainFall[i]}");
            }
            Console.ReadLine();
        }
    }
}
