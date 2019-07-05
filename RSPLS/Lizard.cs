using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public class Lizard : Gesture
    {

        //member variables (Has A)
        // contructor
        public Lizard(string gestureMove)
        {
            gestureMove = "lizard";
            moveName = gestureMove;
        }
        //member methods (Can Do)

        //List<string> canBeat = new List<string>() { "Paper", "Spock" };

        public override string CompareGesture(string playerTwoGesture)
        {

            if (playerTwoGesture == "paper")
            {
                Console.WriteLine("Lizard eats Paper, Lizard wins.");
                return "win";
            }
            else if (playerTwoGesture == "spock")
            {
                Console.WriteLine("Lizard poisons Spock, Lizard wins.");
                return "win";
            }
            else if (playerTwoGesture == "lizard")
            {
                Console.WriteLine("Both players chose Lizard, game is a tie");
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
