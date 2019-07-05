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
        public abstract string CompareGesture(string playerTwoGesture);

    }

}
