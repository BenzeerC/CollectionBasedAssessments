using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBasedAssessments
{
    //WAP to create a list using ArrayList. Iterate over collections to display data


    internal class Program7
    {
        static void Main(string[] args)
        {
            ArrayList MyList = new ArrayList();
            MyList.Add("Rohan");
            MyList.Add(23);
            MyList.Add("Science");
            MyList.Add(96.3);
            MyList.Add(false);

            foreach(Object item in MyList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
