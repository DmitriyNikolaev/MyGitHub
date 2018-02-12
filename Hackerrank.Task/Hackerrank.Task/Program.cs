using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 4 5
            // 10 14
            string[] arr_temp = "1 2 3 4 5".Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            MiniMaxSum.miniMaxSum(arr);
            Console.ReadKey();
        }
    }
}
