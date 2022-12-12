using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2.Задан одномерный массив A[1..15]. 
Определить сумму чѐтных положительных элементов массива. */

namespace Lab_4_2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[15];
            Random r = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(-20, 20);
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n");

            // Классический способ.
            int sum = 0;
            for (int i = 0; i < A.Length; i++)            
                if (A[i] > 0 && A[i]%2 == 0)
                    sum += A[i];
            Console.WriteLine($"Сумма четных положительных элементов = {sum}");

            // С помощью Linq.
            Console.WriteLine($"Сумма четных положительных элементов = " +
                $"{A.Where(x => x > 0 && x % 2 == 0).Sum()}");

            Console.ReadKey();
        }
    }
}
