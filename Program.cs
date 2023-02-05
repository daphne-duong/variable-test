using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5, num6;
            int firstThree, lastFour, multiplication, subtraction;

            Console.Write("Please enter your first number having 2 digits : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your second number having digits  : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your third number having 2 digits : ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your fourth number having 2 digits: ");
            num4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your fifth number having 2 digits : ");
            num5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your sixth number having 2 digits : ");
            num6 = Convert.ToDouble(Console.ReadLine());

            firstThree = (int)(num1 + num2 + num3);
            lastFour = (int)(num3 + num4 + num5 + num6);
            multiplication = firstThree * lastFour;
            subtraction = (int)(firstThree - num6);

            Console.WriteLine($"\nThe addition of the first three numbers called number a1 is: {firstThree}");
            Console.WriteLine($"The addition of the last three numbers called number a2 is:    {lastFour}");
            Console.WriteLine($"The multiplication of number a1 and number a2 is:              {multiplication}");
            Console.WriteLine($"The subtraction of the sixth number from number a1 is:         {subtraction}");

            Console.ReadKey();
        }
    }
}
