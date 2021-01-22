using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionarys<string, int> kisiler = new MyDictionarys<string, int>();
            kisiler.Add("zişan", 22);
            kisiler.Add("müşoo", 23);
            kisiler.Add("küpp", 22);
            for (int i = 0; i < kisiler.Item.Length; i++)
            {
                Console.WriteLine( kisiler.Item[i] + " - " + kisiler.Value[i]);
            }

        }
    }
   
 

}
