using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spellchecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spellchecker.myDictionary dictionary = new Spellchecker.myDictionary();
           
            Console.WriteLine("Bitte geben Sie einen Satz ein!");

            string userInput = Console.ReadLine();
            Regex rgx = new Regex("[^a-zA-Z -]");

            string[] splittedInput = userInput.Split(' ');

            foreach (var item in splittedInput)
            {
                string itemRgx = rgx.Replace(item, "");
                if (dictionary.Contains(itemRgx))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(itemRgx + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(item + " ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            



            Console.ReadKey();

        }
    }
}
