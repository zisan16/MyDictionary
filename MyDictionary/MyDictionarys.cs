using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionarys<T,V>
    {
        
            T[] item;
            T[] tempitem;
            V[] value;
            V[] tempvalue;
            public MyDictionarys()
            {
                item = new T[0];
                value = new V[0];
            }
            public void Add(T items, V values)
            {
                tempitem = item;
                tempvalue = value;
                item = new T[item.Length + 1];
                value = new V[value.Length + 1];

                for (int i = 0; i < tempitem.Length; i++)
                {
                    item[i] = tempitem[i];
                    value[i] = tempvalue[i];
                }

                item[item.Length - 1] = items;
                value[value.Length - 1] = values;
            }
            public int Length
            {
                get { return item.Length; }
            }

            public T[] Item
            {
                get { return item; }
            }
            public V[] Value
            {
                get { return value; }
            }
        

    }
}
