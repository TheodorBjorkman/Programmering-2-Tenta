using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericData
{
    public class DataList<T>
    {
        T[] value = new T[1];
        T[] newVal;
        int length = 1;

        public void Add(T addVal)
        {
            newVal = new T[length];
            for (int i = 0; i < length; i++)
            {
                newVal[i] = value[i];
            }
            newVal[length] = addVal;
        }
    }
}