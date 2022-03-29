using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class Item<T>
    {
        #region Worst cse
        //public byte Quality;
        //public string _Quality;
        //public char _quality;

        //public Item(byte quality)
        //{
        //    Quality = quality;
        //}

        //public Item(string quality)
        //{
        //    _Quality = quality;
        //}

        //public Item(char quality)
        //{
        //    _quality = quality;
        //}
        #endregion

        public T Quality;

        public Item(T quality)
        {
            Quality = quality;
        }
    }
}
