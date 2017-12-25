
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace practise_work
{
    public class RangeOfArray
    {
        public int lowest_index;
        public int uppest_index;
        public int[] arr;
        public RangeOfArray(int low_index, int upper_index)
        {
            this.lowest_index = low_index;
            this.uppest_index = upper_index;
            arr = new int[(upper_index - low_index) + 1];
        }
        public void PrintArray(RangeOfArray array, int lower_index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                WriteLine((i + lower_index) + " элемент массива " + arr[i]);
            }
        }




    }
}