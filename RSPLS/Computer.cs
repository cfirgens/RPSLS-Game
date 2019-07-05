using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Computer : Player
    {
        public Computer()
        {
            Console.WriteLine(playerName);
        }
        //member methods (Can Do)
        public override void GetName()
        {
            Console.WriteLine("What name would you like to give the A.I.?\n");
            playerName = Console.ReadLine();            
        }

        public override void GetGesture()
        {
            List<string> gestures = new List<string>() { "Rock", "Scissors", "Paper", "Lizard", "Spock" };
            int gestureNumber = new Random().Next(0, 4);
            playerGesture = (gestures[gestureNumber]);
        }
    }
}
