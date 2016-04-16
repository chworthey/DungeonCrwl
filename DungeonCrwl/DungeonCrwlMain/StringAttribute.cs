using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public abstract class StringAttribute : AttributeComponent
    {
        public string Value { get; set; }

        public StringAttribute(string componentName)
            : base(componentName)
        { }
    }
}
