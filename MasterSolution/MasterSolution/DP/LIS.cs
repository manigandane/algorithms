using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSolution.DP
{
    public class LIS
    {
        public static int GetLis(int[] array)
        {
            int length = array.Length;
            int[] tempResult = new int[length];
            for (int i = 0; i < length; i++)
            {
                tempResult[i] = 1;
            }

            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] > array[j] && tempResult[i] < tempResult[j] + 1)
                    {
                        tempResult[i] = tempResult[j] + 1;
                    }
                }
            }

            return tempResult.Max();
        }
    }
}
