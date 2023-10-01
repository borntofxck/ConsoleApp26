using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int x = input.IndexOf('(');
            int y = input.IndexOf(')');
            if (x != -1 && y != -1 && y > x)
            {
                string result = input.Substring(x + 1, y - x - 1);
                Console.WriteLine("Символы между скобками: " + result);
            }
            else
            {
                Console.WriteLine("Неверный формат строки или скобки не найдены.");
            }
        }
    }
}
