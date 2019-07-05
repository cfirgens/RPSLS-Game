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

            Console.ReadLine();

            Console.ReadLine();

            player1.GetName();

            Console.ReadLine();

            GetPlayers();

            Console.ReadLine();

            Console.ReadLine();

            while (player1.score < 2 && player2.score < 2)
            {
                player1.GetGesture();

                Console.WriteLine("player 1 chose: " + player1.playerGesture);

                Console.ReadLine();

                player2.GetGesture();

                Console.WriteLine("computer chose:" + player2.playerGesture);

                Console.ReadLine();

                InstatinateGesture(player1.playerGesture);

                string playerTwoGesture = player2.playerGesture;

                string doesWin = player1.gesture.CompareGesture(playerTwoGesture);

                AddScore(doesWin);

                Console.WriteLine(player1.playerName + "'s score is " + player1.score);
                Console.WriteLine(player2.playerName + "'s score is " + player2.score);

                Console.ReadLine();

            }

            AnnounceWinner(player1.score, player2.score);

            Console.ReadLine();


        }


        public void Welcome()
        {
            Console.WriteLine("Welcome to ROCK!PAPER!SCISSORS!SPOCK?LIZARD??\nDo you know the rules?");

            string rulesDisplay = Console.ReadLine();
            if(rulesDisplay == "no" || rulesDisplay == "n")
            {
                Console.WriteLine("The game is quite simple, it is a two player game that plays much like how you would imagine" +
                " with a few new rules. \nIt is best out of three games. \nRock beats Lizard and Scissors \nPaper beats Rock and Spock \n Scissors beats Paper and Lizard \n" +
                "Lizard beats Spock and Paper \nSpock beats Rock and Scissors");
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


        public void InstatinateGesture(string playerGesture)
        {
            if (playerGesture == "rock")
            {
                player1.gesture = new Rock("rock");
                
            }
            else if (playerGesture == "lizard")
            {
                player1.gesture = new Lizard("lizard");
            }
            else if (playerGesture == "spock")
            {
                player1.gesture = new Spock("spock");
            }
            else if (playerGesture == "paper")
            {
                player1.gesture = new Paper("paper");
            }
            else if (playerGesture == "scissors")
            {
                player1.gesture = new Scissors("scissors");
            }

        }

        public void AddScore(string doesWin)
        {
            if(doesWin == "win")
            {
                player1.score++;
            }
            else if(doesWin == "lose")
            {
                player2.score++;
            }
            
        }

        public void AnnounceWinner(int player1score, int player2score)
        {
            if(player1score == 2)
            {
                Console.WriteLine(player1.playerName + " has won the game!");
            }
            else if (player2score ==2)
            {
                Console.WriteLine(player2.playerName + " has won the game!");
            }
        }

    }
}
