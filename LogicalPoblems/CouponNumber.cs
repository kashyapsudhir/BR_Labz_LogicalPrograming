using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class CouponNumber
    {
        public static int FindCouponNumber(int num)
        {


            int[] arr = new int[10];
            Random random = new Random();
            arr[0] = random.Next(0, num);
            for (int i = 1; i < 10; i++)
            {
                int coupon = random.Next(0, num);
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] != coupon)
                    {
                        arr[i] = coupon;
                    }
                    else
                    {
                        i--;
                        break;
                    }
                }
            }
            return arr[9];

        }

    }

}