using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
             
            

            Console.WriteLine("Finf the Perfect number within a given number of range");
            Console.WriteLine("input the starting range");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the ending range");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int n = min; n <= max; n++)
            {
                //int i = 1;
                int sum = 0;
                for(int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    //i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }

        }

    }

}