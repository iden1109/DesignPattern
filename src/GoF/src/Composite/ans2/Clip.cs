/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Composite.Ans2
{
    public class Clip : Weapon
	{
		IList<Weapon> list = new List<Weapon>();

		public virtual bool add(Weapon aWeapon)
	    {
            list.Add(aWeapon);
            return true;
	    }

        public virtual bool remove(Weapon aWeapon)
	    {
            return list.Remove(aWeapon);
    	}
	
    	public virtual Weapon getChild(int aIndex)
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
