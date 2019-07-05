using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Game
    {
        Player player1 = new Human();
        Player player2;

        public void runGame()
        {
            Welcome();

            player1.GetName();

            GetPlayers();

            BestOfThree();
            
            AnnounceWinner(player1.score, player2.score);
            
        }

        private void Welcome()
        {
            Console.WriteLine("Welcome to ROCK!PAPER!SCISSORS!SPOCK?LIZARD??\n\n\nDo you know the rules?");

            string rulesDisplay = Console.ReadLine();
            if(rulesDisplay == "no" || rulesDisplay == "n")
            {
                Console.WriteLine("The game is quite simple, it is a two player game that plays much like how you would imagine" +
                " with a few new rules. \nIt is best out of three games. \nRock beats Lizard and Scissors \nPaper beats Rock and Spock \n Scissors beats Paper and Lizard \n" +
                "Lizard beats Spock and Paper \nSpock beats Rock and Scissors\n");
            }
        }
        private void GetPlayers()
        {
            Console.WriteLine("Would you like to play against a human or A.I?\n");
            string opponent = Console.ReadLine();
            if (opponent == "Human"|| opponent == "human")
                {
                player2 = new Human();
                player2.GetName();
                }
            else
            {
                player2 = new Computer();
                player2.GetName();
            }
        }
        
        private void InstatinateGesture(string playerGesture)
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

        private void AddScore(string doesWin)
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

        private void AnnounceWinner(int player1score, int player2score)
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

        private void Replay()
        {
            Console.WriteLine("Would you like to replay? Yes or no.");

            string replay = Console.ReadLine();
            if (replay == "y" || replay == "yes")
            {
                player1.score = 0;
                player2.score = 0;
                BestOfThree();
            }
        }
        
        private void BestOfThree()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                player1.GetGesture();

                Console.WriteLine(player1.playerName + " chose " + player1.playerGesture + "\n");

                player2.GetGesture();

                Console.WriteLine(player2.playerName + " chose " + player2.playerGesture + "\n");

                InstatinateGesture(player1.playerGesture);

                string playerTwoGesture = player2.playerGesture;

                string doesWin = player1.gesture.CompareGesture(playerTwoGesture);

                AddScore(doesWin);

                Console.WriteLine(player1.playerName + "'s score is " + player1.score + "\n");
                Console.WriteLine(player2.playerName + "'s score is " + player2.score + "\n");

                Console.ReadLine();

            }
        }

    }
}
