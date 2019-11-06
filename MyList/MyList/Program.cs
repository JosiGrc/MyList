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

            MyList<bool> testList = new MyList<bool>();

            testList.Add(true);
            testList.ToString();



            Console.ReadLine();

        }
    }
}
