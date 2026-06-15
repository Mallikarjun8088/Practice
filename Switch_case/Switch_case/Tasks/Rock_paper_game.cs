using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Tasks
{
    class Rock_paper_game
    {
        static void Main5(string[] args)
        {
            string player;
            string computer;
            bool playagain = true;
            Random random = new Random();
            string winner;

            while (playagain)
            {
                player = "";
                computer = "";
                winner = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
                {
                    Console.Write("Enter Rock or Paper or Scissor : ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

               

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "Rock";
                        break;
                    case 2:
                        computer = "Paper";
                        break;
                    case 3:
                        computer = "Scissor";
                        break;
                }

                Console.WriteLine("Computer : " + computer);
                Console.WriteLine("Player : " + player);

                switch (winner)
                {
                    case "draw":
                        if (player == "ROCK" && computer == " ROCK")
                        {
                            Console.WriteLine("It's Draw");
                        }
                        else if (player == "PAPER" && computer == " PAPER")
                        {
                            Console.WriteLine("It's Draw");
                        }
                        else if (player == "SCISSOR" && computer == " SCISSOR")
                        {
                            Console.WriteLine("It's Draw");
                        }
                        break;

                    case "winner":
                        if (player == "ROCK" && computer == " SCISSOR")
                        {
                            Console.WriteLine(" Player wines");
                        }
                        else if (player == "SCISSOR" && computer == " PAPER")
                        {
                            Console.WriteLine(" Player wines");
                        }
                        else if (player == "PAPER" && computer == " ROCK")
                        {
                            Console.WriteLine("Compute WINES");
                        }

                        else if (player == "ROCK" && computer == " PAPER")
                        {
                            Console.WriteLine("COMPUTER WINES");
                        }

                        else if (player == "SCISSOR" && computer == " ROCK")
                        {
                            Console.WriteLine(" Computer wines");
                        }
                        else if (player == "PAPER" && computer == " SCISSOR")
                        {
                            Console.WriteLine("COMPUTER WINES");
                        }
                        break;
                }
                Console.Write("WINNER IS :" +winner);
            }



        }
    }
}
