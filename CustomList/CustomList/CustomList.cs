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
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                list3.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                list3.Add(list2[i]);
            }
            return list3;
        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            if (list1.count > list2.count)
            {
                foreach (T value in list2)
                {
                    list1.Remove(value);
                }
                return list1;
            }
            else if (list1.count < list2.count)
            {
                foreach (T value in list1)
                {
                    list2.Remove(value);
                }
                return list2;
            }
            return list1;
        }
        public CustomList<T> ZipperList(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> zipperList = new CustomList<T>();
            int list = 0;

            if (list1.count == list2.count || list1.count < list2.count)
            {
                list = list1.count;
            }
            else if (list1.count > list2.count)
            {
                list = list2.count;
            }
            for (int i = 0; i < list; i++)
            {
                zipperList.Add(list1[i]);
                zipperList.Add(list2[i]);
            }
            return zipperList;            
        }
    }
}
