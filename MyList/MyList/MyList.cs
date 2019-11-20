using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T> : IEnumerable<T>
    {
        //Member Variables
        // create variables/properties for both count and capacity
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

        public static MyList<T> Zip(MyList<T>listOne, MyList<T> listTwo)
        {
            MyList<T> zippedList = new MyList<T>();

            if (listOne.Count > listTwo.Count)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    zippedList.Add(listOne[i]);

                    for (int j = 0; j < listTwo.Count; j++)
                    {
                        zippedList.Add(listTwo[i]);
                        break;
                    }
                }
                return zippedList;
            }

            else
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    zippedList.Add(listTwo[i]);

                    for (int j = 0; j < listOne.Count; j++)
                    {
                        zippedList.Add(listOne[i]);
                        break;
                    }
                }
            }
             return zippedList;           
        
        }

        public static MyList<T> operator + (MyList<T> listOne, MyList<T> listTwo)
        {
            MyList<T> addedList = new MyList<T>();

            foreach (T item in listOne)
            {
                addedList.Add(item);
            }
            foreach (T item in listTwo)
            {
                addedList.Add(item);
            }
            return addedList;
        }

        public static MyList<T> operator - (MyList<T> listOne, MyList<T> listTwo)
        {
            MyList<T> newList = new MyList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    if (Equals(listOne[i], listTwo[j]))
                    {
                        break;
                    }
                    else if (j == listTwo.count - 1)
                    {
                        newList.Add(listOne[i]);
                    }
                }
            }
            return newList;
        }




















        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
                

            

        
    
}
         
