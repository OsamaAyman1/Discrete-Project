using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, z;

            Console.WriteLine("Enter number1");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2");

            for (n2 = int.Parse(Console.ReadLine()); n2 <= n1; n2++)
            {
                for (z = 2; z <= n2; z++)
                    if (n2 % z == 0)
                    {
                        break;
                    }
                if (n2 == z)
                {
                    Console.WriteLine(z);
                }
                
            }


            














            Console.ReadKey();
        }
    }
}
