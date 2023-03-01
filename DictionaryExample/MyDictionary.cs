using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Dictionary<T1, T2> //generic class
    {
        KeyValuePair<T1, T2>[] items;


        public Dictionary()  //constructor
        {
            items = new KeyValuePair<T1, T2>[0];
        }
        public void Add(T1 item1, T2 item2)
        {
            KeyValuePair<T1, T2>[] tempArray = items; //gecici dizi önceki değerleri saklar
            items = new KeyValuePair<T1, T2>[items.Length + 1]; //dizinin eleman sayısını 1 arttırır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //items eski değerlerini almış oldu
            }
            items[items.Length - 1] = new KeyValuePair<T1, T2>(item1, item2);
        }
        public int Count
        {
            get { return items.Length; }
        }

    }


}
}
