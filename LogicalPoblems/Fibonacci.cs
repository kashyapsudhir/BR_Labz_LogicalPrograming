using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPoblems
{
    public class Fibonacci
    {
        public static void DisPlayFibonacci()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int number;

            Console.WriteLine("Enter the number of Element");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }



        }
    }
}
