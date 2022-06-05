using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bạn tên gì?:");
            string name = Console.ReadLine();
            Console.WriteLine("Ban sinh nam may:");
            int yob = Convert.ToInt32(Console.ReadLine());
            int age = 2022 - yob;
            Console.WriteLine("Hello " + name + ", bạn được " + age + " tuổi");
            Console.WriteLine("Thanks");
        }
    }
}
