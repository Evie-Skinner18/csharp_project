using System;

namespace EviesProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int runningTotal = 0;
            Console.WriteLine("How many minutes have you exercised today? ");

            string userInput = Console.ReadLine();
            int minutesExercised = int.Parse(userInput);
            Console.WriteLine("You have exercised for " + minutesExercised + " minutes today.");
            runningTotal = minutesExercised + runningTotal;
            Console.WriteLine("This brings your running total to... " + runningTotal + ". Keep it up!");
        }
    }
}
