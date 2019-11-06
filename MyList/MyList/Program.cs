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

            MyList<string> testList = new MyList<string>();

            testList.Add("string");
            testList.ToString();



            Console.ReadLine();

        }
    }
}
