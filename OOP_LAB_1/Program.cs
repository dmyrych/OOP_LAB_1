using System;


namespace OOP_LAB_1
{
    class MainClass
    {
        delegate int randomInt();
        delegate double averageInt(randomInt[] arr);
        private static Random random = new Random();

        delegate double simpleAverageInt(int q, int w, int e);
        public static void Main(string[] args)
        {
            //Answer to the task 1 is in the Calculation.cs
            Сalculations calculations = new Сalculations();
            calculations.DoThings();
            //End of task 1
            randomInt integer = () =>
            {
                return random.Next(1, 10);
            };
            randomInt[] randarr = new randomInt[10];
            //averageInt getAverage = () => 
            for(int i = 0; i < randarr.Length; i++)
            {
                randarr[i] = integer;
            }
            averageInt av = delegate (randomInt[] r)
            {
                double d = 0f;
                for (int i = 0; i < r.Length; i++)
                {
                    d += r[i]();
                }
                return d/r.Length;
            };
            Console.WriteLine($"Average number is: {av(randarr)}");
            //End of Task 2

            simpleAverageInt simpleAverage = delegate (int q, int w, int e)
            {
                return (q + w + e) / 3;
            };
            Console.Write("And the average for the task 3 is: ");
            Console.WriteLine(simpleAverage(12, 69, 228));
        }
    }
}
