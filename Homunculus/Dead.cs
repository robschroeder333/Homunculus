using System;
using System.Collections.Generic;
using System.Text;

namespace Homunculus
{
    abstract class Dead
    {
        public Dictionary<string, int> Resources { get; set; }
        public virtual int DecayRate { get; set; }
        public int DecayLevel { get; private set; }
        int maxDecay = 100;
        public virtual void Decay() 
        {
            if (DecayLevel + DecayRate >= maxDecay)
            {
                //event to destroy this object
            }
            else
                DecayLevel += DecayRate;
        }

    }
}
