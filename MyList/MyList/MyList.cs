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
        private bool itemFind;
        

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
            itemFind = false;
            items = new T[capacity];               
        }

        //Methods        
             
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

        ////////////////////////////////////////////Remove Method Below
        //make a new array but without the item that was removed
        //if the item that needs to be removed is in the array make new array without the item that needs to be removed

        public void Remove(T itemToRemove)
        {
            T[] temporaryArray = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                if (itemToRemove.Equals(items[i]))
                {
                    temporaryArray[i] = items[i + 1];
                    items = temporaryArray;
                    count--;
                }
            }
            if (itemFind)
                                              //if the item to remove is not found
        }                                    //then loop through all the items in the array until is found
                                             //create a bool that is false until the item to remove is found


                

            

        
    }
}
         
