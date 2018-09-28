using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180928DojoMonday
{
    public class Rotate_Array
    {
        public static int[] Rotate( int[] array, int counter)
        {
            if (counter <= array[array.Length - 1])
            {
                List<int> inputArray = new List<int>();
                int i = 0;
                while (i < counter)
                {
                    inputArray.Insert(0, inputArray[-1]);
                    inputArray.Remove(inputArray[-1]);
                    i++;
                }
                int[] outArray = inputArray.ToArray();
                return outArray;
            }
            else
            {
                return null;
            }
        }
    }
}
