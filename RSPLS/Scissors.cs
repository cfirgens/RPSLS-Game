using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public class Scissors : Gesture
    {
        public Scissors(string gestureMove)
        {
            gestureMove = "scissors";
            moveName = gestureMove;
        }
        //member methods (Can Do)

        //List<string> canBeat = new List<string>() { "Paper", "Spock" };

        public override string CompareGesture(string playerTwoGesture)
        {

            if (playerTwoGesture == "paper" || playerTwoGesture == "Paper")
            {
                Console.WriteLine("Scissors cuts Paper, Scissors win");
                return "win";
            }
            else if (playerTwoGesture == "lizard" || playerTwoGesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard, Scissors win.");
                return "win";
            }
            else if (playerTwoGesture == "scissors")
            {
                Console.WriteLine("Both players chose Scissors, game is a tie");
                return "tie";
            }
            else
            {
                Console.WriteLine("Player 1 loses");
                return "lose";
            }

        }
    }
}
