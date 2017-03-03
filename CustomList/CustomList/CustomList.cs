using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
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
            yield return count;
            foreach(var value in myArray)
            {
                yield return value;
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
        public void Remove(T value)
        {

        }
        public void AddLists()
        {

        }

        public void CustomIterator(T v)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)myArray).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)myArray).GetEnumerator();
        }
    }
}
