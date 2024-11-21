using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    internal class Program
    {
        static int uyfgchsklufevyg(int a)
        {

            if (a <= 0) return -a;

            else return a;
        }
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("met un nombre ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("le nombre est {0}",a);
            Console.WriteLine("le nombre est {0}", uyfgchsklufevyg(a));

        }
    }
}
