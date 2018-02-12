using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Task
{
    class MiniMaxSum
    {
        public static void miniMaxSum(int[] arr)
        {
            var count = arr.Length;
            List<long> minMax = new List<long>();
            for (int i = 0; i < count; i++)
            {
                List<long> sum = new List<long>();
                for (int j = 0; j < count; j++)
                {
                    if (j != i)
                    {
                        sum.Add(arr[j]);
                    }
                }
                minMax.Add(sum.Sum());
            }
            Console.WriteLine("{0} {1}", minMax.Min(), minMax.Max());

            // как вариант
            //long minSum = arr.Sum() - arr.Max();
            //long maxSum = arr.Sum() - arr.Min();
            //Console.WriteLine("{0} {1}", minSum, maxSum);
        }
    }
}
