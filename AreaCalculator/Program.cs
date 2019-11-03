using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            string flag;
            do
            {
                Console.WriteLine("\t\t\tChoose Form Below Options");
                Console.WriteLine("\t\t\t1. Area of Circle");
                Console.WriteLine("\t\t\t2. Area of Square");
                Console.WriteLine("\t\t\t3. Area of Rectangle");
                Console.WriteLine("\t\t\t4. Quit");
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("You selected Area of Circle");
                        Console.WriteLine("Enter Radius of a Circle");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Circle oCircle = new Circle(r);
                        Console.WriteLine("Radius of Circle: " + oCircle.GetRadius());
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Area of Circle: " + oCircle.GetArea());
                        break;
                    case 2:
                        Console.WriteLine("You selected Area of Square");
                        Console.WriteLine("Enter Side of Square");
                        double s = Convert.ToDouble(Console.ReadLine());
                        Square oSquare = new Square(s);
                        Console.WriteLine("Side of Square: " + oSquare.GetWidth());
                        break;
                    case 3:
                        break;

                    case 4:
                        break;

                    default:

                        break;
                }
                Console.WriteLine("Do you want to continue ? (Y/N)");
                flag = Console.ReadLine();
            } while (flag.ToUpper() == "Y");
        }
    }
}
