using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.Composite.Exercise
{
    class ShotgunBullet : Bullet
    {
        public override void fire()
        {
            Console.WriteLine("發射散彈.");
        }
    }
}
