using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtFirstProject
{
    class FunctionsDemo
    {

        static void Change1(int X)
        {
            Console.Write("Inside Change1 ");
            X = 100;
            Console.WriteLine(X);
        }

        static void Change2(ref int X)
        {
            Console.Write("Inside Change2");
            X = 100;
            Console.WriteLine(X);
        }
        // Default /  Optional Parameters
        static void SI(int p=12000, int rate=9, int time=10)
        {
            Console.WriteLine((p*rate*time)/100);
        }
        static void DisplayDetails(int rn, string name, string batch, int marks)
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Batch Code is " + batch);
            Console.WriteLine("Marks are " + marks);
        }

        // Method with Output Parameters
        static void Calculation(int x, int y, out int add, out int subt, 
            out int product, out int quotient)
        {
            add = x + y;
            subt = x - y;
            product = x * y;
            quotient = x / y;
        }
        static void AddNumbers(int x, int y)
        {
            Console.WriteLine(x +  y);
        }
        //static int AddNumbers(int x, int y)
        //{
        //    Console.WriteLine(x + y);
        //}
        static void AddNumbers(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        static void AddNumbers(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        static void Main()
        {
            int x = 10;
            int y = 10;

            // Method Overloading
            AddNumbers(x, y);
            AddNumbers(1, 2, 3);
            AddNumbers(10.8f, 20.7f);

            // Named Parameters
            DisplayDetails(name: "Deepak", marks: 90, batch: "B001", rn: 8);

            // To Call method which is using Output Parameters
            int add, subt, prod, qu;
            Calculation(10, 20, out add, out subt, out prod, out qu);
            Console.WriteLine("Addition is " + add); ;
            Console.WriteLine("Subtraction is " + subt);
            SI(10000, 2, 7);
            SI(100000, 2);
            SI();
            SI(13000);
            SI(rate: 8);

            int X = 10;
            Console.WriteLine("Value of X in Main Method is " + X); ;
          // Call By Value
            Change1(X);
            Console.WriteLine("Value of X in Main Method after calling Change1 is " + X);
          // Call By Reference
            Change2(ref X);
            Console.WriteLine("Value of X in Main Method after calling Change2 is " + X);

        }

    }
}
