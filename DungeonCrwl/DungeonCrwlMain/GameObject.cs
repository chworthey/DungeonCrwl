using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public abstract class GameObject
    {
        public List<AttributeComponent> Attributes { get; set; } = new List<AttributeComponent>();
    }
}
