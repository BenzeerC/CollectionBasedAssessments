using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBasedAssessments
{
    //Create matrix of 3* 3 & calculate addition & display the details

    internal class Program3
    {
        static void Main(string[] args)
        {
            int[,] Array1 = new int[3, 3]
            {
                {10,20,30},
                {40,50,60},
                {70,80,90}
            };
            Console.WriteLine("==========First Matrix:===========\n");
            for (int i=0; i<Array1.GetLength(0); i++)
            {
                for (int j = 0; j < Array1.GetLength(1); j++)
                {
                   
                    Console.Write(Array1[i,j]+" ");
                    //Array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                //Array1[i,j] = 0;
            }
            Console.WriteLine("==========Secound Matrix:==============\n");

            int[,] Array2 = new int[3, 3]
            {
                {11,22,33},
                {44,55,66},
                {77,88,99}
            };

            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {

                    Console.Write(Array2[i, j] + " ");
                    //Array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                //Array1[i,j] = 0;
            }
            //Addition of 2 matrix
            Console.WriteLine("================Addition of 3*3 matrix=============");

            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    int add = Array1[(int)i, (int)j] + Array2[(int)i, (int)j];
                    Console.Write(" "+add+" ");

                    //Console.Write(Array2[i, j] + " ");
                    //Array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                //Array1[i,j] = 0;
            }
            Console.ReadLine();





        }   }
}
