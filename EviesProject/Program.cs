using System;

namespace EviesProject
{
    class MainClass
    {
        // does the loop go here?
        public static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing == true)
            {
                int runningTotal = 0;
                Console.WriteLine("How many minutes have you exercised today? Type 'exit' at any time to exit the app. ");

                string userInput = Console.ReadLine();

                if(userInput == "exit"){
                    keepGoing = false;
                    Console.WriteLine("Seeya!");
                }
                else {
                    int minutesExercised = int.Parse(userInput);
                    Console.WriteLine("You have exercised for " + minutesExercised + " minutes today.");
                    runningTotal = minutesExercised + runningTotal; 
                    Console.WriteLine("This brings your running total to... " + runningTotal + ". ");

                        if (minutesExercised < 5)
                        {
                        Console.WriteLine("Believe in yourself gurrl. You can do better than that! Now sweat baby sweat!");
                        }
                        else if (minutesExercised > 30)
                        {
                            Console.WriteLine("You've exercised for more than half an hour today... Keep it up and you'll be the next Chuck Norris in no time!");
                        }

  



                } //end of else

            } // end of while loop




            // option to see a random motivational message. Computer pick random numebr

        } //end of Main

    } // end of class

} //end of namespace
