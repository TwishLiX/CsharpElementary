using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variant 18");
            Console.WriteLine("Enter a number : ");
            var number = Console.ReadLine();
            int cube = Cube(Convert.ToInt32(number));
            Console.WriteLine("Cube of the number : {0}", cube);
        }
        public static int Cube(int number)
        {
            return number * number * number;
        }
    }
}
