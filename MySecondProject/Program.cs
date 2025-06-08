// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            // Console.WriteLine("Write your name:");
            // string input = Console.ReadLine();

            // Console.WriteLine($"Hello, {input}");
            /* long bigNumber = 90000000L;

            decimal money = 55.99M;

            Console.WriteLine(bigNumber);
            Console.WriteLine(money);

            string age = "32";
            // int ageValue = 32;
            int ageValue = Convert.ToInt32(age);
            Console.WriteLine($"Long number: {ageValue}");

            string textLong = "-9000000000";
            // long longNumber = 9000000000L;
            long longNumber = Convert.ToInt64(textLong);
            Console.WriteLine($"Long number: {longNumber}");

            string textNegative = "-55,2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine($"Double number: {negative}");

            string textPrecission = "5,00001";
            // float precission = 5.000001F;
            float precission = Convert.ToSingle(textPrecission);
            Console.WriteLine($"Float number: {precission}"); */

            // guess the number
            /*Console.WriteLine("Write the numberA");
            string numberA = Console.ReadLine();
            int numberAValue = Convert.ToInt32(numberA);


            Console.WriteLine("Write the numberB");
            string numberB = Console.ReadLine();
            int numberBValue = Convert.ToInt32(numberB);

            Console.WriteLine($"What is the result of {numberAValue} x {numberBValue}?");
            int answerValue = Convert.ToInt32(Console.ReadLine());

            int actualAnswer = numberAValue * numberBValue;

            if (actualAnswer == answerValue)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Wrong answer.");
            }*/

            // String Formatting
            /*double number = 1000 / 12.34;
            // double number = 1000D / 12;
            Console.WriteLine(number);
            Console.WriteLine(string.Format("{0:0.00}", number));
            Console.WriteLine(string.Format("{0:0.#}", number));

            double money = -22.50D;
            Console.WriteLine(string.Format("${0:0.00}", money));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));*/

            /*Console.WriteLine("Enter a number:");
            string input = Console.ReadLine(); // in case of error - putting a string with number like for example "22l"
            int num = 0;
            // int number = Convert.ToInt32(input);
            bool success = int.TryParse(input, out num);
            Console.Write($"{success}\n2");
            Console.WriteLine($"The number is {num}");*/

            // Times Table
            /*Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }*/

            // FizzBuzz Game
            const int count = 15;

            var threeIsDivisible = false;
            var fiveIsDivisible = false;

            for (var i = 1; i <= count; i++)
            {
                threeIsDivisible = i % 3 == 0;
                fiveIsDivisible = i % 5 == 0;
                
                if (threeIsDivisible && fiveIsDivisible)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                    // return;
                }

                if (threeIsDivisible)
                {
                    Console.WriteLine("Fizz");
                    continue;
                    // return;
                }

                if (fiveIsDivisible)
                {
                    Console.WriteLine("Buzz");
                    // return;
                }
                else
                {
                    Console.WriteLine(i);    
                }
            }
        }
    }
}