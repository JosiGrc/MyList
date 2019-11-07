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
                IncreaseCapacity();
            }
            items[count] = itemToAdd;
            count++;
        }

        public void IncreaseCapacity()
        {
            T[] increasedArray = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                increasedArray[i] = items[i];
            }
            capacity *= 2;
            items = increasedArray;
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

        public static MyList<T> Zip(MyList<T>newList)
        {
            MyList<T> zippedList = new MyList<T>();

            if(newList.Count > 0)
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    zippedList.Add(newList[i]);                  
                }
                return zippedList;
            }
            //else
            //{
            //    for (int i = 0; i < even.Count; i++)
            //    {
            //        zippedList.Add(even[i]);
            //        for (int j = 0; j < odd.Count; j++)
            //        {
            //            zippedList.Add(odd[j]);
            //            break;
            //        }
            //    }
            //}
            return zippedList;
        }
    }
                

            

        
    
}
         
