/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Composite.Ans
{
    public class Clip : Weapon
	{
		IList<Weapon> list = new List<Weapon>();

		public override bool add(Weapon aWeapon)
	    {
            list.Add(aWeapon);
            return true;
	    }

        public override bool remove(Weapon aWeapon)
	    {
            return list.Remove(aWeapon);
    	}
	
    	public override Weapon getChild(int aIndex)
	    {
            return list[aIndex];
	    }

    	public override void fire()
	    {
		    foreach (Weapon weapon in list)
		    {
			    weapon.fire();
		    }
	    }
    }
}
