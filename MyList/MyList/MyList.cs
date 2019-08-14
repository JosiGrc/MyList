using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {
        //Member Variables
        private T[] items;

        public T this[int itemToIndex]
        {
            get
            {
                return items[itemToIndex];
            }




        }

        //Ctor
        public MyList()
        {
            items = new T[0];
         
        }

        //Methods
        public void Add(T itemToAdd)
        {
            items[0] = itemToAdd;

        }

    }
}
