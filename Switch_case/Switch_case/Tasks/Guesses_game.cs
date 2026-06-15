using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Tasks
{


    class Guesses_game
    {
        static void Main4(string[] args)
        {
            Random random = new Random();
            int number;
            int gusses;
            int number_of_gusses;
            bool playagain = true;
            int min = 0;
            int max = 100;
            string response;

            while (playagain)
            {
                gusses = 0;
                number_of_gusses = 0;
                response = "";
                number = random.Next(min,max+1);
                while (gusses != number) 
                {
                    Console.WriteLine(" Guesses the number between: " +min +"-"+max +":");
                    gusses = Convert.ToInt32(Console.ReadLine());
                    

                    if (gusses > number)
                    {
                        Console.WriteLine("Guesse is to HIGH");
                        Console.WriteLine("Guesses the number between : " +gusses);
                    }
                    else if (gusses < number)
                    {
                        Console.WriteLine("Guesse is to LOW");
                    }
                    number_of_gusses++;
                }
                if (gusses == number)
                {
                    Console.WriteLine("YOU WIN");
                    Console.WriteLine("Number :" + number);
                    Console.WriteLine("Number of guesses : " +number_of_gusses);
                }
                Console.WriteLine("Do you like to play again (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }

            }

        } 
    }
    
}


