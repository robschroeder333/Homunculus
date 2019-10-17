using System;
using System.Collections.Generic;
using System.Text;

namespace Homunculus
{
    public enum Need { Breath, Water, Food, Sleep, Happiness}
    abstract class Alive
    {
        public int Health { get; private set; }
        public int Age { get; private set; }
        public int Size { get; private set; }
        public Dictionary<string, int> Resources { get; private set; }
        public Dictionary<Need, int> Needs { get; private set; }

        public virtual void Die(Alive subType) 
        {
            //create new object with rescources carried over
        }
        public virtual void Grow() 
        {
            Size++;
        }
        public virtual void Breed() { }
    }
}
