using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public class NameAttribute : StringAttribute
    {
        public NameAttribute()
            : base("Name")
        { }
    }
}
