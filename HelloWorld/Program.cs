using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heloo World");
            Console.WriteLine("Olá, Digite um número para calcular a tabuada ");
            String num = Console.ReadLine();

            int numInt = int.Parse(num);

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + "x" + i + "=" + numInt * i);
            }
                Console.ReadLine();
        }
    }
}
