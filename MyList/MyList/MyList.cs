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
        private int count;
        

        //Indexer Property
        public T this[int itemToIndex]
        {
            get
            {
                return items[itemToIndex];
            }
        }
        //Count Property
        public int Count
        {
            get
            {
                return this.count;
            }

            
        }
        //Capacity Property
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        //Ctor
        public MyList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];               
        }

        //Methods
        //Add method works, now make it better. To add new item to the next open index
        public void Add(T itemToAdd)
        {

            if (count == capacity)
            {
                capacity += 4;
            }
            else items[count] = itemToAdd;
            {               
                count++;
            }
        }

    }
}
