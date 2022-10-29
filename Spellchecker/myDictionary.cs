using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellchecker
{
    public class myDictionary
    {
        libLinkedList.ILinkedList<string> myDict = new libLinkedList.SinglyLinkedList<string>();


        public myDictionary()
        {
            this.Init();
        }


        internal void Init()
        {
            string source = "C:\\Users\\reich\\source\\repos\\Spellchecker\\german.dic";
            string[] lines = System.IO.File.ReadAllLines(source, Encoding.UTF8);
            foreach (string s in lines)
            {
                myDict.Add(s);
            }
            Console.WriteLine("Wörterbuch initialisiert!");
        }

        public bool Contains(string s)
        {
            return myDict.Contains(s);
        }
    }
}
