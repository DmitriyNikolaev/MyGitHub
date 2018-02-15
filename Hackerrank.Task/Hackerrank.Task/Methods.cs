using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Task
{
    public class Methods
    {
        public static string timeConversion(string s)
        {
            //Console.WriteLine(DateTime.Parse(s).ToString("HH:mm:ss"));
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }

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

        public static int birthdayCakeCandles(int n, int[] ar)
        {
            var max = ar.Max();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == max) count++;
            }
            return count;
        }

        public static string misereNim(int[] s)
        {
            return "";
        }
    }
}
