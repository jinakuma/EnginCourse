using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{

    class MyDictionay<K,V>
    {
        K[] keys;
        V[] values;
        public void MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempK = keys;
            V[] tempV = values;
            keys = new K[keys.Length+1];
            values = new V[values.Length + 1];
            for (int i = 0; i < tempK.Length; i++)
            {
                keys[i] = tempK[i];
                values[i] = tempV[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;        }

    }
}
