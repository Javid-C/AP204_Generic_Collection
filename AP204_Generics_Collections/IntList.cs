using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class IntList
    {
        private int[] arr;

        public int Count { get => arr.Length;}

        public IntList()
        {
            arr = new int[0];
        }

        public int[] GetArray()
        {
            return arr;
        }

        public void Add(int number)
        {
            Array.Resize(ref arr,arr.Length+1);
            arr[arr.Length - 1] = number;
        }

        


    }
}
