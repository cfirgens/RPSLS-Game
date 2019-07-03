using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Human : Player
    {
        //member variables (Has A)
        
        // contructor
        public Human()
        {
            Console.WriteLine(playerName);
            
        }
        //member methods (Can Do)
        public override void GetName()
        {
            Console.WriteLine("What would you like to be called?");
            playerName = Console.ReadLine();
        }

        public override void GetGesture()
        {
            Console.WriteLine("Please choose your gesture");

            string playerGestureInput = Console.ReadLine();

            string playerGestureLower =  playerGestureInput.ToLower();
            
            if (playerGestureLower == "rock" || playerGesture == "paper" || playerGesture == "scissors" || playerGesture == "spock" || playerGesture == "lizard")
            {
                playerGesture = playerGestureLower;
            }
            else
            {
                Console.WriteLine("Please enter a valid gesture");
                GetGesture();
            }

        }
    }
}
