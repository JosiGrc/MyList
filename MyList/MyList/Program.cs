using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> MyList = new MyList<int>();
            MyList<int> testList = new MyList<int>();
           
            testList.Add(1);
            testList.ToString();




            Console.WriteLine(testList);
            Console.ReadLine();

        }
    }
}
