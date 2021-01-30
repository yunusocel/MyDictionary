using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Manisa");
            myList.Add("Ankara");
            myList.Add("İstanbul");
            Console.WriteLine(myList.Count);
            
        }
    }
}
