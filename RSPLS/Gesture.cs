using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    public abstract class Gesture
    {
        public string moveName = "";
        //member variables (Has A)
        // contructor
        //member methods (Can Do)
        public abstract string CompareGesture(string playerTwoGesture);

        //public abstract void checkGesture();
    }

}
