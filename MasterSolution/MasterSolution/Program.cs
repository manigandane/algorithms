using MasterSolution.DP;
using System;

namespace MasterSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Result of 9 is {ByteLandian.GetDollars(9)}");
            //Console.WriteLine($"Result of 19 is {ByteLandian.GetDollars(19)}");
            //Console.WriteLine($"Result of 25 is {ByteLandian.GetDollars(25)}");
            //Console.WriteLine($"Result of 520 is {ByteLandian.GetDollars(520)}");

            //Console.WriteLine($"Subset of sum 17 in [2,4,6,9] exist?: {SubsetSum.DoesSubsetExist(new int[] { 2, 4, 6, 9 }, 17)}");
            //Console.WriteLine($"Subset of sum 17 in [2,4,6,8] exist?: {SubsetSum.DoesSubsetExist(new int[] { 2, 4, 6, 8 }, 17)}");

            Console.WriteLine($"Longest increasing sub sequence length of[3, 10, 2, 1, 20]: {LIS.GetLis(new int[] { 3, 10, 2, 1, 20 })}");
            Console.WriteLine($"Longest increasing sub sequence length of[50, 3, 10, 7, 40, 80]: {LIS.GetLis(new int[] { 50, 3, 10, 7, 40, 80 })}");
            Console.WriteLine($"Longest increasing sub sequence length of[10, 22, 9, 33, 21, 50, 41, 60 ]: {LIS.GetLis(new int[] { 10, 22, 9, 33, 21, 50, 41, 60 })}");

            Console.ReadLine();
        }
    }
}
