using System;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            equation:
            Console.WriteLine("Welcome to calculator\n");
            Console.WriteLine("What  do want to do\n 1 = addition, 2 = substract, 3 = multiply, 4 = divide, 5 = power, 6=random number, 7=square root sum, 8=percentage, 9=square root, 10=logarithm\n");
            int thing;
            thing = Convert.ToInt32(Console.ReadLine());

            if(thing == 1)
            {
                Console.WriteLine("\nEnter the numbers");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float y;
                y = Convert.ToInt32(Console.ReadLine());
                float sum = x + y;
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 2)
            {
                Console.WriteLine("\nEnter the numbers");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float y;
                y = Convert.ToInt32(Console.ReadLine());
                float sum = x - y;
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 3)
            {
                Console.WriteLine("\nEnter the numbers");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float y;
                y = Convert.ToInt32(Console.ReadLine());
                float sum = x * y;
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 4)
            {
                Console.WriteLine("\nEnter the numbers");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float y;
                y = Convert.ToInt32(Console.ReadLine());
                float sum = x / y;
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 5)
            {
                Console.WriteLine("\nEnter the numbers");
                double x;
                x = Convert.ToInt32(Console.ReadLine());
                double y;
                y = Convert.ToInt32(Console.ReadLine());
                double sum = Math.Pow(x, y);
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 6)
            {
                Console.WriteLine("\nEnter the numbers");
                int x;
                x = Convert.ToInt32(Console.ReadLine());
                int y;
                y = Convert.ToInt32(Console.ReadLine());
                int sum = rnd.Next(x, y + 1);
                Console.WriteLine("random number is  " + sum);
            }

            if (thing == 7)
            {
                Console.WriteLine("\nEnter the numbers");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float y;
                y = Convert.ToInt32(Console.ReadLine());
                float sum = (float) (Math.Sqrt(x) + Math.Sqrt(y));
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 8)
            {
                Console.WriteLine("\nFirst enter the total and then the percentage number");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float y;
                y = Convert.ToInt32(Console.ReadLine());
                float sum = (y * 100) / x;
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 9)
            {
                Console.WriteLine("\nEnter the number");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float sum = ((float)Math.Sqrt(x));
                Console.WriteLine("result is  " + sum);
            }

            if (thing == 10)
            {
                Console.WriteLine("\nEnter the number");
                float x;
                x = Convert.ToInt32(Console.ReadLine());
                float sum = ((float)Math.Log(x));
                Console.WriteLine("result is  " + sum);
            }

            else
            {
                Console.WriteLine("\nthat is not an option\n");
                goto equation;
            }
        } 
    }
}
