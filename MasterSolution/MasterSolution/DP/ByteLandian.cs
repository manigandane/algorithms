using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSolution.DP
{
    /*Each Bytelandian gold coin has an integer number written on it. 
     * A coin n can be exchanged in a bank into three coins: n/2, n/3 and n/4. 
     * But these numbers are all rounded down (the banks have to make a profit).
     * You can also sell Bytelandian coins for American dollars. The exchange rate is 1:1. 
     * But you can not buy Bytelandian coins.
     * You have one gold coin of value n, 0 <= n <= 1000000000. 
     * What is the maximum amount of American dollars you can get for it?
     */

    public class ByteLandian
    {
        static Dictionary<int,int> resultStorage = new Dictionary<int, int>();
        public static int GetDollars(int coinCount)
        {
            if (coinCount < 10)
                return coinCount;

            if (resultStorage.ContainsKey(coinCount))
            {
                return resultStorage[coinCount];
            }
            else
            {
                int tempResult = Math.Max(coinCount, GetDollars(coinCount / 2) + GetDollars(coinCount / 3) + GetDollars(coinCount / 4));
                resultStorage[coinCount] = tempResult;
                return tempResult;
            }
        }
    }
}
