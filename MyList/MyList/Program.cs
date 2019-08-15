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

            MyList.Add(4);
            testList.Add(1);
            MyList.Add(5);
            MyList.Add(10);
            MyList.Add(8);
            MyList.Add(11);


            Console.ReadLine();

        }
    }
}
