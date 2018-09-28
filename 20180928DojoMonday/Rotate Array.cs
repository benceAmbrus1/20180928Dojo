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
                int[] result = new int[array.Length];
                List<int> inputArray = array.OfType<int>().ToList();
                int i = 0;
                while (i < counter)
                {
                    int[] arraySlice = new int[array.Length - counter];
                    int[] arrayRotated = new int[counter];
                    Array.Copy(array, 0, arraySlice, 0, array.Length - counter);
                    Array.Copy(array, array.Length - counter, arrayRotated, 0, counter);
                    result = arrayRotated.Concat(arraySlice).ToArray();
                    i++;
                }
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
