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
            //set
            //{
            //    items[itemToIndex] = value;
            //}
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
        //i want to increase the array size but also want to keep the fifth item
        //grab everything from the old array into the new one
        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] temporaryArray = new T[capacity];
                for (int i = 0; i < count; i ++) 
                {
                    temporaryArray[i] = items[i];
                }
                items = temporaryArray;
            }
            items[count] = itemToAdd;
            count++;
        }
        public void Remove(T intemToRemove)
        {

        }

    }
}
