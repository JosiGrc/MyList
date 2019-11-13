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

            List<int> odd = new List<int>() { 1, 3, 5 }; List<int> even = new List<int>() { 2, 4, 6 };


            odd.Zip(odd, even);



            Console.ReadLine();

        }
    }
}
