using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class ComputerList
    {
        private Computer[] arr;

        public int Count { get => arr.Length; }

        public ComputerList()
        {
            arr = new Computer[0];
        }

        public Computer[] GetArray()
        {
            return arr;
        }

        public void Add(Computer comp)
        {
            Array.Resize(ref arr,arr.Length + 1);
            arr[arr.Length - 1] = comp;
        }

    }
}
