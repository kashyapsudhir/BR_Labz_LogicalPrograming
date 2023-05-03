using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Reverse
    {
        public static void ReverseNumber()
        {
            int reverse = 0, remainder;
            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n = n / 10;
            }
            Console.WriteLine("Reverse number : " + reverse);
        }
    }
}