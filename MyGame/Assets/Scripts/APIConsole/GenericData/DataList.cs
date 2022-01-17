using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericData
{
    public class DataList<T>
    {
        /// <summary>
        /// A generic array with the capability of getting and adding, but not setting the full or parts of the array.
        /// </summary>
        private T[] items = new T[1];
        private T[] newVal;
        private int length = 1;
        public T[] Items
        {
            get { return items; }
        }
        public void Add(T addVal)
        {
            newVal = new T[length];
            for (int i = 0; i < length; i++)
            {
                newVal[i] = items[i];
            }
            newVal[length] = addVal;
        }
    }
}