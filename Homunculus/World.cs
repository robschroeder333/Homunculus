using System;
using System.Collections.Generic;
using System.Text;

namespace Homunculus
{
    class World
    {
        List<Dead> dead = new List<Dead>();
        List<Alive> living = new List<Alive>();
        public List<Area> Map = new List<Area>();

        public World()
        {
            ActivateSeed();
        }

        void ActivateSeed()
        {

        }
    }
}
