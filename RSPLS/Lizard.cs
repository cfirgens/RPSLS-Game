using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public class Lizard : Gesture
    {
        public Lizard(string gestureMove)
        {
            gestureMove = "lizard";
            moveName = gestureMove;
        }

        public override string CompareGesture(string playerTwoGesture)
        {

            if (playerTwoGesture == "paper" || playerTwoGesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper, Lizard wins.");
                return "win";
            }
            else if (playerTwoGesture == "spock" || playerTwoGesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock, Lizard wins.");
                return "win";
            }
            else if (playerTwoGesture == "lizard" || playerTwoGesture == "Lizard")
            {
                Console.WriteLine("Both players chose Lizard, game is a tie");
                return "tie";
            }
            else
            {
                Console.WriteLine(playerTwoGesture + " beats Lizard, " + playerTwoGesture + " wins.");
                return "lose";
            }

        }
    }
}
