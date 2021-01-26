using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(110, "Gonca");
            myDictionary.Add(120, "Etem");
            myDictionary.Add(130, "Ateş");
            myDictionary.Add(140, "Kaptan");
            myDictionary.Say();
           
        }
    }
}
