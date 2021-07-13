using System; // Namespace 

enum Days {  Monday , Tuesday, Wednesday, Thursday, Friday};
enum Choice : byte {  Add=1, Subtract , Multiply , Divide, Remainder};
class Program
{
    static void Main()
    {

      
        int x, y;
        int choice;
        Console.WriteLine("ENter Value of x");
        x = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("ENter Value of y");
        y = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter your choice");
        choice =  Convert.ToByte(Console.ReadLine());

        switch (choice)
        {

            case (int)Choice.Add: 
           
                  Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y)); 
                  break;
            case (int)Choice.Subtract:
           
                Console.WriteLine("Difference of {0} and {1} is {2}", x, y, (x - y));
                break;

            case (int) Choice.Multiply:
                Console.WriteLine("Product of {0} and {1} is {2}", x, y, (x * y));
                break;

            case (int)Choice.Divide:
             
                Console.WriteLine("Quotient of {0} and {1} is {2}", x, y, (x / y));
                break;
            case (int) Choice.Remainder:
                Console.WriteLine("Remainder of {0} and {1} is {2}", x, y, (x % y));
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;

        }
    }
}
