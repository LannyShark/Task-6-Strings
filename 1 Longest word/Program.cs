using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Longest_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string longestWord = "";
            foreach (string s in stringArray)
            {
                if (s.Length > longestWord.Length)
                    longestWord = s;
            }
            Console.WriteLine("Самое длинное слово в прдложении \"{0}\"", longestWord);
            Console.ReadKey();
        }
    }
}
