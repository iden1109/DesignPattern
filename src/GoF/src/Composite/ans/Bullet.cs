/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Composite.Ans
{
    public abstract class Bullet : Weapon
	{
        public override bool add(Weapon aWeapon)
        {
            throw new Exception("Operation is not supported.");
        }

        public override bool remove(Weapon aWeapon)
        {
            throw new Exception("Operation is not supported.");
        }

        public override Weapon getChild(int aIndex)
        {
            throw new Exception("Operation is not supported.");
        }
    }
}
