using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace practise_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int low_index;
            int upper_index;
            WriteLine("Введите наименьший индекс");
            while (!int.TryParse(ReadLine(), out low_index))
            {
                WriteLine("Error");
            }
            WriteLine("Введите наибольший индекс");
            while (!int.TryParse(ReadLine(), out upper_index))
            {
                WriteLine("Error");
            }
            Clear();
            Random rand = new Random();

            if (!(low_index > upper_index))
            {
                RangeOfArray array = new RangeOfArray(low_index, upper_index);
                for (int i = 0; i < array.arr.Length; i++)
                {
                    array.arr[i] = rand.Next(10);
                }
                array.PrintArray(array, low_index);
            }

            ReadLine();

        }
    }

}

