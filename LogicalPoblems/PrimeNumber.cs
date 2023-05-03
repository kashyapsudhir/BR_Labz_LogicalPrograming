using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            int i = 1, count=0;
            Console.WriteLine("Enter your number");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < a; n++)
            {

                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;

                }
                if (count == 2)
                {
                    Console.Write(i + ",");

                }
                i++;

            }
        }
    }

}