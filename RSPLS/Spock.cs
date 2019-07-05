﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public class Spock : Gesture
    {
        public Spock(string gestureMove)
        {
            gestureMove = "Spock";
            moveName = gestureMove;
        }
        //member methods (Can Do)

        //List<string> canBeat = new List<string>() { "Paper", "Spock" };

        public override string CompareGesture(string playerTwoGesture)
        {

            if (playerTwoGesture == "rock" || playerTwoGesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock, Spock wins.");
                return "win";
            }
            else if (playerTwoGesture == "scissors" || playerTwoGesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors, Spock wins");
                return "win";
            }
            else if (playerTwoGesture == "spock" || playerTwoGesture == "Spock")
            {
                Console.WriteLine("Both players chose Spock, game is a tie");
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
