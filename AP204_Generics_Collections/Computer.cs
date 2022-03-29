using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class Computer/*:ICollection*/
    {
        public int Id;
        public string Model;
        public byte Ram;
        public string Memory;
        public static int count;

        //public int Count => throw new NotImplementedException();

        //public bool IsSynchronized => throw new NotImplementedException();

        //public object SyncRoot => throw new NotImplementedException();

        static Computer()
        {
            count = 0;
        }

       

        public Computer(string model, byte ram,string memory)
        {
            Id = ++count;
            Model = model;
            Ram = ram;
            Memory = memory;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Model: {Model}, Ram: {Ram}, Memory: {Memory}";
        }

        public void Test()
        {
            Console.WriteLine("Test");
        }

        //public void CopyTo(Array array, int index)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
