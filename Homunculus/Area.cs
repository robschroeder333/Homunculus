using System;
using System.Collections.Generic;
using System.Text;

namespace Homunculus
{
    class Area
    {
        public List<Area> ConnectsTo = new List<Area>();
        public string Name { get; private set; }
        bool isOutside;

        public Area(string name)
        {
            Name = name;
        }

        public void Connect(Area[] connections)
        {
            foreach (var area in connections)
            {
                ConnectsTo.Add(area);
            }
        }
    }
}
