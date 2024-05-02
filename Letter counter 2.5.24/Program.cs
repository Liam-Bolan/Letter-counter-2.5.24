using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_counter_2._5._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> Letters = new Dictionary<char, int>();
            Console.Write("Enter a string: ");
            string String = Console.ReadLine();
            for(int i = 0; i < String.Length; i++)
            {
                if (Letters.ContainsKey(String[i]))
                {
                    Letters[String[i]]++;
                }
                else
                {
                    Letters.Add(String[i], 1);
                }
            }
            foreach(var letters in Letters)
            {
                Console.WriteLine($"({letters.Key}) - ({letters.Value})");
            }
            Console.ReadLine();
            
        }
    }
}
