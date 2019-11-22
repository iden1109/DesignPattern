using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.Composite.Exercise
{
    public abstract class Weapon
    {
        public abstract bool add(Weapon weapon);
        public abstract bool remove(Weapon weapon);
        public abstract Weapon getChild(int index);
        public abstract void fire();
    }
}
