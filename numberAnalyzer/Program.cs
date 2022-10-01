using System;

namespace numberAnalyzer
{
    class program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Do you like Apples <y> or <n>?");
                string apples = Console.ReadLine().ToLower() == "y" ? "how do you like them apples?" : "how do you dislike them apples?"; 
                Console.WriteLine("Enter a valid integer between 1 and 100");
                var theNumber = Console.ReadLine();
                if(!int.TryParse(theNumber, out var number))
                {
                    Console.WriteLine("That's not a valid integer try again...");
                    continue;
                }
                if(number < 1 || number > 100)
                {
                    Console.WriteLine("That isn't between 1 and 100 : ");
                    continue;
                }
                bool isOdd = number % 2 != 0;
                if(isOdd && number > 60)
                {
                    Console.WriteLine($"Odd and greater than 60. {apples}");
                }
                if(isOdd && number < 60)
                {
                    Console.WriteLine($"Odd and less than 60 {apples}");
                }
                if(!isOdd && number > 60)
                {
                    Console.WriteLine($"Even and greater than 60. {apples}");
                }
                if(!isOdd && number >= 26 && number <= 60)
                {
                    Console.WriteLine($"Even and between 26 and 60. {apples}");
                }
                if(!isOdd && number >= 2 && number <= 24)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                Console.WriteLine("Would you like to try that again? <y> or <n> :");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "y")
                {
                    continue;
                }
                Console.WriteLine("Have a great day!");
                break;
            }
            
        }
    }
}
