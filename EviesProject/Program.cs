using System;

namespace EviesProject
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            bool keepGoing = true;
            bool wellStage = false;

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
                    wellStage = true;

                    while(wellStage == true) {

                        // exercise calculator
                        Console.WriteLine("How many minutes have you exercised today? Type 'bye' to leave the exercise calculator. ");
                        string exerciseInput = Console.ReadLine();

                        // FIRST check if the user wants to leave or not
                        if (userInput == "bye")
                        {
                            wellStage = false;
                            Console.WriteLine("Exiting calculator... ");
                        }
                        else {
                            Console.WriteLine("You've exercised " + exerciseInput + " minutes today. ");

                            int minutes = int.Parse(exerciseInput);


                            if (minutes < 5)
                            {
                                Console.WriteLine("Believe in yourself gurrl. You can do better than that! Now sweat baby sweat!");
                            }
                            else if (minutes > 30)
                            {
                                Console.WriteLine("You've exercised for more than half an hour today... Keep it up and you'll be the next Chuck Norris in no time!");
                            }

                            runningTotal = minutes + runningTotal;
                            Console.WriteLine("Your running total of minutes exercised is now " + runningTotal + ". ");

                        } //end of else
                        
                    } // end of calculator while loop


                } //end of else if

                else {
                    Console.WriteLine("Time for a motivational message. ");
                    Random num = new Random();
                    int randomNum = num.Next(0, 10);

                    switch(randomNum)
                    {
                        case 0:
                            Console.WriteLine("'Just DO it! Dont let your dreams be dreams.' - Shia LaBoeuf ");
                            break;
                        case 1:
                            Console.WriteLine("'I fear not the man who has practised 10,000 kicks once, but I fear the man who has practised one kick 10,000 times.' - Bruce Lee ");
                            break;
                        case 2:
                            Console.WriteLine(" 'Ive missed more than 9,000 shots in my career. Ive lost almost 300 games. 26 times, Ive been trusted to take the game winning shot and missed. Ive failed over and over and over again in my life. And that is why I succeed.' – Michael Jordan ");
                            break;
                        case 3:
                            Console.WriteLine("'It isnt the mountains ahead to climb that wear you out; its the pebble in your shoe.' – Muhammad Ali ");
                            break;
                        case 4:
                            Console.WriteLine("'It does not matter how slowly you go as long as you do not stop' - Confucius");
                            break;
                        case 5:
                            Console.WriteLine("'In the struggle between the stone and water, in time, the water wins' - Japanese proverb ");
                            break;
                        case 6:
                            Console.WriteLine("'It is not the answer that enlightens, but the question.' - Eugene Ionesco ");
                            break;
                        case 7:
                            Console.WriteLine("'You have power over your mind, not outside events. Realise this, and you will find strength.' - Marcus Aurelius ");
                            break;
                        case 8:
                            Console.WriteLine("'Force has no place where there is need of skill.' - Herodotus");
                            break;
                        case 9:
                            Console.WriteLine("'Hard work beats talent when talent doesn’t work hard.' - Tim Notke");
                            break;
                        default:
                            Console.WriteLine("'To give any less than your best is to sacrifice a gift.' - Steve Prefontiane");
                            break;
                    } //end of switch

                } // end of else

             
            } // end of while loop


        } //end of Main

    } // end of class

} //end of namespace


