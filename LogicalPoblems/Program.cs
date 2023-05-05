using LogicalProblems;
using System;

namespace LogicalProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
           
            Console.WriteLine("Hello Logical Programing Problem");
            Console.Write("Enter the value for the coupon number: ");
            
            int couponInput = Convert.ToInt32(Console.ReadLine());
            
            int number = CouponNumber.FindCouponNumber(couponInput);
            
            Console.WriteLine("Coupon Number: " + number);

        }
    }
}
