using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSolution.DP
{
    public class SubsetSum
    {
        public static bool DoesSubsetExist(int[] setOfNos, int sum)
        {
            bool[,] tempResult = new bool[setOfNos.Length + 1, sum + 1]; // by default all will set to false;

            for (int i = 0; i < setOfNos.Length; i++)
            {
                tempResult[i, 0] = true;
            }

            //for (int j = 0; j < sum; j++)
            //{
            //    tempResult[0, j] = false;
            //}

            for (int i = 1; i <= setOfNos.Length; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (tempResult[i - 1, j])
                    {
                        tempResult[i, j] = tempResult[i - 1, j];
                    }
                    else if(setOfNos[i-1] <= j)
                    {
                        tempResult[i, j] = tempResult[i - 1, j - setOfNos[i-1]];
                    }
                }
            }

            return tempResult[setOfNos.Length, sum];
        }
    }
}
