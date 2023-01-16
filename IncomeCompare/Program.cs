using System;


namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Anonymous Income Comparison Program!\n==========================================");
            Console.WriteLine("Person1");
            Console.WriteLine("Please type in your hourly rate");
            string p1HourlyRate = Console.ReadLine();
            Console.WriteLine("Your Hourly rate is " + p1HourlyRate);
            Console.WriteLine("Please type in how many hours you worked this week");
            string p1HoursWorked = Console.ReadLine();
            Console.WriteLine("You worked " + p1HoursWorked + " hours.");
            double p1Income = Convert.ToDouble(p1HourlyRate) * Convert.ToDouble(p1HoursWorked);
            Console.WriteLine("Person 1 Income is " + p1Income + "\n ========================================== ");
            Console.ReadLine();

            Console.WriteLine("Person2");
            Console.WriteLine("Please type in your hourly rate");
            string p2HourlyRate = Console.ReadLine();
            Console.WriteLine("Your Hourly rate is " + p2HourlyRate);
            Console.WriteLine("Please type in how many hours you worked this week");
            string p2HoursWorked = Console.ReadLine();
            Console.WriteLine("You worked " + p2HoursWorked + " hours.");
            double p2Income = Convert.ToDouble(p2HourlyRate) * Convert.ToDouble(p2HoursWorked);
            Console.WriteLine("Person 2 Income is " + p2Income + "\n ========================================== ");


            double p1annualIncome = p1Income * 48;
            double p2annualIncome = p2Income * 48;
            Console.WriteLine("Annual Sellery of Person 1: \n" + p1annualIncome);
            Console.WriteLine("Annual Sellery of Person 2: \n" + p2annualIncome + "\n ========================================== ");

            bool compareIncome = p1annualIncome > p2annualIncome;
            Console.WriteLine("Person 1 makes more Than Person 2?" + compareIncome);

            Console.ReadLine();




        }
    }
}