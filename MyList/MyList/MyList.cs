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
        // crreate variables/properties for both count and capacity
        private T[] items;
        private int capacity;

        //Indexer Property
        public T this[int itemToIndex]
        {
            get
            {
                return items[itemToIndex];
            }
        }
        //Count Property
        public int CountList
        {
            get
            {
                return this.CountList;
            }

            
        }
        //Capacity Property
        public int ListCapacity
        {
            get
            {
                return capacity;
            }
        }

        //Ctor
        public MyList()
        {
            capacity = 4;
            items = new T[capacity];
            
         
        }

        //Methods
        //Add method works, now make it better. To add new item to the next open index
        public void Add(T itemToAdd)
        {
            items[0] = itemToAdd;
            if (items.CountList )
            {

            }


        }

    }
}
