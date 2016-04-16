using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public abstract class AttributeComponent
    {
        public string ComponentName { get; private set; }

        public AttributeComponent(string componentName)
        {
            ComponentName = componentName;
        }
    }
}
