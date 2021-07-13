using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtFirstProject
{
    class Arays2Demo
    {
        static void Main()
        {
            int[,] num = new int[3, 3]
            {
                {1,2,3 },
                {1,2,3 },

                {1,2,3 },

            };
            //Console.WriteLine("ENter Elemets");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        num[i, j] = Convert.ToByte(Console.ReadLine());
            //    }
            //}
            Console.WriteLine("Elements are ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}