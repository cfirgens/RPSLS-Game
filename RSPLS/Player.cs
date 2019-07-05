using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public abstract class Player
    {
        //member variables (Has A)
        public string playerName;
        public string playerGesture;
        public Gesture gesture;
        public int score = 0;


        // contructor
        //public Player(string Name)
        //{
        //    this.playerName = Name;
        //}


        //member methods (Can Do)
        //method to choose name


        public abstract void GetName();

        public abstract void GetGesture();
        

        
    }

}
