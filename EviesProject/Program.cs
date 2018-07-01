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
                Console.WriteLine("How is your exercise regime going? Type 'well' to go to the minutes exercised calculator. Type 'crap' if you need a pick-me-up. Type 'exit' at any time to exit the app and do something better with your life. ");

                string userInput = Console.ReadLine();

                if(userInput == "exit"){
                    keepGoing = false;
                    Console.WriteLine("Seeya!");
                }

                else if (userInput == "well")
                {
                    Console.WriteLine("How many minutes have you exercised today? ");
                    string exerciseInput = Console.ReadLine();
                    Console.WriteLine("You've exercised " + exerciseInput + " minutes today. ");

                    int minutes = int.Parse(exerciseInput);
                    runningTotal = minutes + runningTotal;
                    Console.WriteLine("Your running total of minutes exercised is now " + runningTotal + ". ");
                    if (minutes < 5)
                    {
                        Console.WriteLine("Believe in yourself gurrl. You can do better than that! Now sweat baby sweat!");
                    }
                    else if (minutes > 30)
                    {
                        Console.WriteLine("You've exercised for more than half an hour today... Keep it up and you'll be the next Chuck Norris in no time!");
                    }

                } //end of else if

                else {
                    Console.WriteLine("Time for a motivational message. ");
                }

                //else {
                    //Console.WriteLine("You have exercised for " + userInput + " minutes today.");
                    //int minutesExercised = int.Parse(userInput);
                    //runningTotal = minutesExercised + runningTotal; 
                    //Console.WriteLine("This brings your running total to... " + runningTotal + ". ");

                    //if (minutesExercised < 5) {
                        //Console.WriteLine("Believe in yourself gurrl. You can do better than that! Now sweat baby sweat!");
                        //}
                        //else if (minutesExercised > 30){
                        //    Console.WriteLine("You've exercised for more than half an hour today... Keep it up and you'll be the next Chuck Norris in no time!");
                        //}

  



               // } //end of else

            } // end of while loop




            // option to see a random motivational message. Computer pick random numebr

        } //end of Main

    } // end of class

} //end of namespace


