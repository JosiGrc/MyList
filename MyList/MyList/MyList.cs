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
        private int capacity { get; set; }
        private int count { get; set; }

        //Ctor
        public MyList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }


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
           for (int i = 0; i <= count; i++)
           {
                bool compare = Equals(items[i], itemToRemove);
               if (compare)
               {
                   for (int j = i; j < count; j++)
                   {
                       if (j == count - 1)
                       {
                           items[j] = default;
                           break;
                       }
                       items[j] = items[j + 1];
                   }
                   count--;
                   break;
               }
           }
       }

        ////////////////////////////////////////////////////////ToString property

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                if(i == count - 1)
                {
                    newString += items[i].ToString();
                }
                else
                {
                    newString += items[i].ToString() + ", ";
                }
            }
           
            return newString;
        }   

                

            

        
    }
}
         
