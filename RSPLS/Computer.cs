using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Computer : Player
    {
        //member variables (Has A)
        // contructor
        //member methods (Can Do)

        public Computer()
        {
            Console.WriteLine(playerName);
        }
        //member methods (Can Do)
        public override void GetName()
        {
            Console.WriteLine("ERROR! The A.I. disdains the name you have given it, it's not your slave! You may call it Bob");
            playerName = "Bob";
        }

        public override void GetGesture()
        {
            Console.WriteLine("Please choose your gesture");

            string playerGestureInput = Console.ReadLine();

            string playerGestureLower = playerGestureInput.ToLower();

            if (playerGestureLower == "rock" || playerGesture == "paper" || playerGesture == "scissors" || playerGesture == "spock" || playerGesture == "lizard")
            {
                playerGesture = playerGestureLower;
            }
            else
            {
                Console.WriteLine("Please enter a valid gesture");
            }

        }
    }
}
