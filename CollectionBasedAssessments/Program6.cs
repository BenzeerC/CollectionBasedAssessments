using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBasedAssessments
{
    //WAP to accept an array of 5 integers. Perform Sort(), Reverse(), Copy(), Clear() operations.


    internal class Program6
    {
        static void Main(string[] args)
        {
            int[] list = new int[5] { 55, 33, 22, 44, 11 };
            int[] list2 = new int[6] { 11, 66, 77, 88, 99,100 };

            Console.WriteLine("------After Sorting--------");
            Array.Sort(list);
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
            
            Console.WriteLine("------- Reverse---------");
            Array.Reverse(list);
            foreach(int i1 in list)
            { Console.WriteLine(i1+" "); }
           
            
            Console.WriteLine("------- Copy---------");
            Array.Copy(list, 3, list2,1,2);
            Console.WriteLine("------------------");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("------- Clear---------");
            Array.Clear(list2,0,3);
            foreach (int i4 in list2)
            {
                Console.WriteLine(i4+" ");
            }


        }
        

       
    }
}
