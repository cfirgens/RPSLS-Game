using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public class Rock : Gesture
    {
        public Rock(string gestureMove)
        {
            gestureMove = "rock";
            moveName = gestureMove;
        }
        public override string CompareGesture(string playerTwoGesture)
        {
            
            if (playerTwoGesture == "scissors" || playerTwoGesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors, Rock wins.");
                return "win";
            }
            else if (playerTwoGesture == "lizard" || playerTwoGesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard, Rock wins.");
                return "win";
            }
            else if (playerTwoGesture == "rock" || playerTwoGesture == "Rock")
            {
                Console.WriteLine("Both players chose Rock, game is a tie");
                return "tie";
            }
            else
            {
                Console.WriteLine(playerTwoGesture + " beats Rock, " + playerTwoGesture + " wins.");
                return "lose";
            }

        }

    }
}
