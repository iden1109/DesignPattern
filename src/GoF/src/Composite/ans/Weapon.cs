/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;

namespace Tw.Teddysoft.Gof.Composite.Ans
{
    public abstract class Weapon
	{
		public abstract bool add(Weapon weapon);
		public abstract bool remove(Weapon weapon);
		public abstract Weapon getChild(int index);
		public abstract void fire();
	}
}
