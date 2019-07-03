using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Game
    {
        //member variables (Has A)
        Player player1 = new Human();
        Player player2;

        // contructor


        //member methods (Can Do)

        public void runGame()
        {
            Welcome();
            player1.GetName();
            GetPlayers();

            Console.ReadLine();

            Console.WriteLine(player1.playerName +"'s score is "+ player1.score);
            Console.WriteLine(player2.playerName +"'s score is " + player2.score);

            player1.GetGesture();

            Console.ReadLine();

            Console.WriteLine(player1.playerGesture);
            
            Console.ReadLine();
            //while (player1.score < 2 || player2.score < 2)
            //{
                
            //}



        }


        public void Welcome()
        {
            Console.WriteLine("Welcome to ROCK!PAPER!SCISSORS!SPOCK?LIZARD??\n Do you need to know the rules?");

            string rulesDisplay = Console.ReadLine();
            if(rulesDisplay == "yes" || rulesDisplay == "y")
            {
                Console.WriteLine("The game is quite simple, it is a two player game that plays much like how you would imagine" +
                " with a few new rules. \n Rock beats Lizard and Scissors \n Paper beats Rock and Spock \n Scissors beats Paper and Lizard \n" +
                " Lizard beats Spock and Paper \n Spock beats Rock and Scissors");
            }
        }
        public void GetPlayers()
        {
            Console.WriteLine("Would you like to play against a human or A.I?");
            string opponent = Console.ReadLine();
            if (opponent == "Human"|| opponent == "human")
                {
                player2 = new Human();
                player2.GetName();
                }
            else
            {
                player2 = new Computer();
                Console.WriteLine(player1.playerName + ", what name would you like to give the A.I.?");
                Console.ReadLine();
                player2.GetName();
            }
        }

    }
}
