using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public class Paper : Gesture
    {
        public Paper(string gestureMove)
        {
            gestureMove = "paper";
            moveName = gestureMove;
        }
        
        public override string CompareGesture(string playerTwoGesture)
        {

            if (playerTwoGesture == "rock" || playerTwoGesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock, Paper wins.");
                return "win";
            }
            else if (playerTwoGesture == "spock" || playerTwoGesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock, Paper wins.");
                return "win";
            }
            else if (playerTwoGesture == "paper" || playerTwoGesture == "Paper")
            {
                Console.WriteLine("Both players chose Paper, game is a tie");
                return "tie";
            }
            else
            {
                Console.WriteLine(playerTwoGesture + " beats paper, "+ playerTwoGesture + " wins.");
                return "lose";
            }

        }
    }
}
