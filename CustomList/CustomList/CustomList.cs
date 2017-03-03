using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        private T[] myArray;
        private int count;
        public int Count { get { return count; } }

        public CustomList()
        {
            count = 0;
            myArray = new T[0];
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return myArray[i];
            }
        }
        public T this[int i]
        {
            get
            {
                return myArray[i];
            }
            set
            {
                myArray[i] = value;
            }

        }

        public void Add(T value)
        {
            T[] newArray = new T[count + 1]; 
            for(int i = 0; i < count; i++)
            {
                newArray[i] = myArray[i];
                
            }
            newArray[count] = value;
            myArray = newArray;
            count++;
        }
        public bool Remove(T value)
        {
            T[] newArray = new T[count - 1];
            bool valueFound = false;
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                if (myArray[i].Equals(value))
                {
                    valueFound = true;                    
                }
                else if (!myArray[i].Equals(value))
                {
                    newArray[j] = myArray[i];
                    j++;
                }
            }
            myArray = newArray;
            count--;
            return valueFound;
                        
        }
        public override string ToString()
        {
            string result = "";
            foreach (T value in myArray)
            {
                result += value.ToString() + ", ";
            }
            return result;
        }
        //public static AddLists()
        //{

        //}

    }
}
