using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (commands.Contains(input))
                {
                    int index = Array.IndexOf(commands, input);
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());

                    int result = funcs[index](x, y);

                    Console.WriteLine(result); 
                }
                else
                {
                    Console.WriteLine("Mistake!");
                }
            }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }
        static int Mul(int x, int y)
        {
            return x * y;
        }
        static int Div(int x, int y)
        {
            return x / y;
        }
        
        static string[] commands = { "add", "sub", "mul", "div" };
        static Func<int, int, int>[] funcs = { Add, Sub, Mul, Div };
    }
}
