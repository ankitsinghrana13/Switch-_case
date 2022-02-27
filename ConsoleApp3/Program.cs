using System;
namespace ConsoleApp3
{
    class program
    {
        static void Main(string[] arg)
        {
            int a,b, choice;
            Console.WriteLine("Adding for choice one");
            Console.WriteLine("Substaction for choice one");
            Console.WriteLine("Multiplication for choice one");

            Console.WriteLine("Enter the choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("you Choice Adding");
                    Console.WriteLine("Enter the value of A");
                    a= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of B");
                    b= Convert.ToInt32(Console.ReadLine());
                   
                    Console.WriteLine("Adding="+ a+b);
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("you Choice ubstraction");
                    Console.WriteLine("Enter the value of A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of B");
                    b = Convert.ToInt32(Console.ReadLine());
                
                    Console.WriteLine("ubstration="+ a+b);
                    Console.ReadLine();

                    break;
                
                case 3:

                    Console.WriteLine("you Choice Multiplication");
                    Console.WriteLine("Enter the value of A");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of B");
                    b = Convert.ToInt32(Console.ReadLine());

                  
                    Console.WriteLine("ubstration="+ a*b);
                    Console.ReadLine();

                    break;

            }


        }
    }

}
