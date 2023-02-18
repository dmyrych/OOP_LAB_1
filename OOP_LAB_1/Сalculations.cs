using System;
namespace OOP_LAB_1
{
    public class Сalculations
    {
        delegate void Sum(int a, int b);
        delegate void Min(int a, int b);
        delegate void Div(int a, int b);
        delegate void Mul(int a, int b);


        public void DoThings()
        {
            Sum sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
            Min min = (x, y) => Console.WriteLine($"{x} - {y} = {x - y}");
            Div div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine($"Failed to calculate {x} / {y}. You can't divide by zero!");
                }
                else
                {
                    Console.WriteLine($"{x} / {y} = {x / y}");
                }

            };
            Mul mul = (x, y) => Console.WriteLine($"{x} * {y} = {x + y}");

            string input;
            int num1, num2;
            Console.WriteLine("Hello, valued user! Would you like to sum(1), min(2), div(3), mult(4) two numbers? Just press a desired number on your keyboard");
            int answ = Int32.Parse(Console.ReadLine());

            switch (answ)
            {
                case 1:
                    {
                        Console.WriteLine("Good! Now enter two numbers, divided by a spacebar: ");
                        input = Console.ReadLine();
                        string[] splittedString = input.Split(' ');
                        num1 = Int32.Parse(splittedString[0]);
                        num2 = Int32.Parse(splittedString[1]);
                        sum(num1, num2);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Good! Now enter two numbers, divided by a spacebar: ");
                        input = Console.ReadLine();
                        string[] splittedString = input.Split(' ');
                        num1 = Int32.Parse(splittedString[0]);
                        num2 = Int32.Parse(splittedString[1]);
                        min(num1, num2);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Good! Now enter two numbers, divided by a spacebar: ");
                        input = Console.ReadLine();
                        string[] splittedString = input.Split(' ');
                        num1 = Int32.Parse(splittedString[0]);
                        num2 = Int32.Parse(splittedString[1]);
                        div(num1, num2);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Good! Now enter two numbers, divided by a spacebar: ");
                        input = Console.ReadLine();
                        string[] splittedString = input.Split(' ');
                        num1 = Int32.Parse(splittedString[0]);
                        num2 = Int32.Parse(splittedString[1]);
                        mul(num1, num2);
                        break;
                    }
            }
        }
    }
}
