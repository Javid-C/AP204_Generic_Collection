using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class StringList
    {
        private string[] arr;

        public int Count { get => arr.Length; }

        public StringList()
        {
            arr = new string[0];
        }

        public string[] GetArray()
        {
            return arr;
        }

        public void Add(string word)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = word;
        }

    }
}
