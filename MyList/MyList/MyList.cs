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


        //Indexer Property
        public T this[int itemToIndex]
        {
            get
            {
                return items[itemToIndex];
            }
        }
        //Count Property
        public int count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        //Ctor
        public MyList()
        {
            items = new T[4];
            
         
        }

        //Methods
        //Add method works, now make it better. To add new item to the next open index
        public void Add(T itemToAdd)
        {
            items[0] = itemToAdd;
            if (items [] == T)
            {

            }


        }

    }
}
