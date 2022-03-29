using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class CustomList<T>/* where T : class,ICollection*/
    {
        private T[] arr;

        public int Count { get => arr.Length; }

        public CustomList()
        {
            arr = new T[0];
        }

        public T[] GetArray()
        {
            return arr;
        }

        public void Add(T comp)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = comp;
        }
    }
}
