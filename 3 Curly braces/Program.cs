using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Curly_braces
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            while (startString.Contains('}'))
            {
                int c = startString.IndexOf('}');
                for (int i = c; i > 0; i--)
                {
                    if (startString[i]=='{')
                    {
                        startString = startString.Remove(i, c-i+1);
                        break;
                    }
                }
            }
            Console.WriteLine(startString);
            Console.ReadKey();
        }
    }
}
