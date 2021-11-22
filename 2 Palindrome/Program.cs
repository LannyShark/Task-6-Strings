using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string startString = Console.ReadLine().ToLower();
            string anotherString = startString;
            int n = startString.Length;
            bool mem = true;
            for (int i = 0, j = n-1; i < n; i++, j--)
            {
                if (startString[i]==' ')
                    i++;
                if (anotherString[j]==' ')
                    j--;
                if (startString[i]!=anotherString[j])
                {
                    mem = false;
                    break;
                }
            }
            if (mem)
                Console.WriteLine("Это предложение палиндром");
            else
                Console.WriteLine("Это предложение не палиндром");
            Console.ReadKey();

        }
    }
}
