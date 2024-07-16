using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrаy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {43, 56, 325, 23, 554, 223, 1 };

            int a = array[0];
            for (int i = 0; i< array.Length; i++)
            {                
                a = a <= array[i] ? a : array[i];               
            }

            Console.WriteLine($"Наименьшее число массива: {a}");

            for (int i = 0; i < array.Length; i++)
            {
                a = a >= array[i] ? a : array[i];
            }

            Console.WriteLine($"Наибольшее число массива: {a}");

            for (int i = 1; i < array.Length; i++)
            {
                a += array[i];
            }

            Console.WriteLine($"Сумма всех членов массива: {a}");
            Console.WriteLine($"среднее арифметическое всех элементов: {a/array.Length}");
            Console.Write("все нечетные значения массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }
            }

            Console.ReadKey();
        }
    }
}
