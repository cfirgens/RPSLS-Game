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
        //member methods (Can Do)

        //List<string> canBeat = new List<string>() { "Paper", "Spock" };

        public override string CompareGesture(string playerTwoGesture)
        {

            if (playerTwoGesture == "rock")
            {
                Console.WriteLine("Paper covers Rock, Paper wins.");
                return "win";
            }
            else if (playerTwoGesture == "spock")
            {
                Console.WriteLine("Paper disproves Spock, Paper wins.");
                return "win";
            }
            else if (playerTwoGesture == "paper")
            {
                Console.WriteLine("Both players chose Paper, game is a tie");
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
