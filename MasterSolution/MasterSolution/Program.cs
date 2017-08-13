using MasterSolution.DP.BytelandianGoldCoin;
using System;

namespace MasterSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result of 9 is {ByteLandian.GetDollars(9)}");
            Console.WriteLine($"Result of 19 is {ByteLandian.GetDollars(19)}");
            Console.WriteLine($"Result of 25 is {ByteLandian.GetDollars(25)}");
            Console.WriteLine($"Result of 520 is {ByteLandian.GetDollars(520)}");

            Console.ReadLine();
        }
    }
}
