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

            MyList<int> odd = new MyList<int>() {1, 2, 3 };
            MyList<int> even = new MyList<int>() {2};


            MyList<int> testList = new MyList<int>();

            testList = odd - even;

            Console.ReadLine();

        }
    }
}
