using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public abstract class Player
    {
        public string playerName;
        public string playerGesture;
        public Gesture gesture;
        public int score = 0;

        public abstract void GetName();

        public abstract void GetGesture();
     
    }

}
