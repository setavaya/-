using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = "чемпионат";

            var result1 = word.Substring(3, 1) + word.Substring(5, 2) + word.Substring(0, 1) + word.Substring(5, 1);
            var result2 = word.Substring(8, 1) + word.Substring(1, 3);

            Console.WriteLine($"В начале было слово \"{word}\".");
            Console.WriteLine($"Мы получили слова \"{result1}\" и \"{result2}\".");
        }
    }
}