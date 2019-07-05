using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Human : Player
    {
        public Human()
        {
            Console.WriteLine(playerName);
            
        }
        public override void GetName()
        {
            Console.WriteLine("What would you like to be called?\n");
            playerName = Console.ReadLine();
        }

        public override void GetGesture()
        {
            do
            {
                Console.WriteLine("\nPlease choose your gesture");
                string playerGestureInput = Console.ReadLine();
                string playerGestureLower = playerGestureInput.ToLower();
                playerGesture = playerGestureLower;
            } while (playerGesture != "rock" && playerGesture != "paper" && playerGesture != "scissors" && playerGesture != "spock" && playerGesture != "lizard");
        }
        
    }
}
