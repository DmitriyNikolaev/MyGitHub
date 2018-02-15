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
            //07:05:45PM
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] s_temp = Console.ReadLine().Split(' ');
                int[] s = Array.ConvertAll(s_temp, Int32.Parse);
                string result = Methods.misereNim(s);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
