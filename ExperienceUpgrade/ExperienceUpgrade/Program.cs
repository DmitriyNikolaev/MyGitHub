using System;

namespace ExperienceUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            WinAPI.GetParentProcess();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
