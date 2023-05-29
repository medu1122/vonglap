using System;
using System.Xml.Serialization;

namespace vonglap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int choice=1;
            while (choice != 0)
            {
                Console.WriteLine("menu");
                Console.WriteLine("draw the triangle");
                Console.WriteLine("draw the square");
                Console.WriteLine("draw the rectangle");
                Console.WriteLine("exit");
                Console.Write("enter : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice");
                        break;
                }
            }

        }
    }
}