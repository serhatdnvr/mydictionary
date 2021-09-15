
using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> isimler = new MyList<int, string>();

            isimler.Add(1, "Serhat");

            isimler.Add(2, "Resul");

            //Console.WriteLine(isimler.Length);
            //Console.WriteLine(isimler.Values);
            //Console.WriteLine(isimler.Keys);


            foreach (var isim in isimler.Values)
            {
                Console.WriteLine(isim);
            }

        }
    }

    class MyList<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        //constructor
        public MyList()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];

        }
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKey = keys;
            keys = new Tkey[keys.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            keys[keys.Length - 1] = key;

            Tvalue[] tempValues = values;
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;


        }

        public int Length
        {
            get { return keys.Length; }
        }

        public Tkey[] Keys
        {
            get { return keys; }
        }

        public Tvalue[] Values
        {
            get { return values; }
        }


    }
}