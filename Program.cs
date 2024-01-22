using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Buiding_a_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // convert a string to a number
            int num = Convert.ToInt32("45"); // yo int 16 hold a norrower range
            Console.WriteLine(num+6);

            int num1= Convert.ToInt32(Console.ReadLine());
            int num2= Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine(num1 + num2);
            // can also convert to double
            double num3= Convert.ToDouble(Console.ReadLine());
            double num4= Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine(num3 + num4);
            Console.Read();

        }
    }
}
