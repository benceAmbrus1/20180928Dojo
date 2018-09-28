using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180928DojoMonday
{
    public class TwoSum
    {
        public static int[] TwoSumMethod( int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i!=j)
                    {
                        if((array[i] + array[j]) == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return null;
        }
    }
}
