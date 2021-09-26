using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> d2 = new MyDictionary<string, string>();
            d2.Add("name", "isim");
        }
        class MyDictionary<Tkey, Tvalue>
        {
            List<KeyValuePair<Tkey, Tvalue>> d;
            public MyDictionary()
            {
                d = new List<KeyValuePair<Tkey, Tvalue>>();
            }
            public void Add(Tkey key, Tvalue value)
            {
                d.Add(new KeyValuePair<Tkey, Tvalue> { Key = key, Value = value });
            }
        }
        class KeyValuePair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }


    }
}
