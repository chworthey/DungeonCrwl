using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public abstract class IntegerAttribute : AttributeComponent
    {
        public int Value { get; set; }

        public IntegerAttribute(string componentName)
            : base(componentName)
        { }
    }
}
