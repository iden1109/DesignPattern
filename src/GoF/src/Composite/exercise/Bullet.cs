/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Composite.Exercise
{
    public abstract class Bullet : Weapon
	{
        public override bool add(Weapon weapon)
        {
            throw new NotImplementedException();
        }

        public override Weapon getChild(int index)
        {
            throw new NotImplementedException();
        }

        public override bool remove(Weapon weapon)
        {
            throw new NotImplementedException();
        }
    }
}
