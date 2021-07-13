using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtFirstProject
{
    class ArraysDemo
    {
        static void Main()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            

            int sum = 0;
            Console.WriteLine("Elements are");
           
                for (int i = 0; i < 10; i++)
            { 
                    sum += num[i];
                Console.WriteLine(num[i]);
            }
            float avg = (float)sum / 10;
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is " + avg);
        }
    }
}
