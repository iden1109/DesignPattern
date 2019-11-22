/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Ans
{
    public abstract class IOPort
	{
		private int address;

		public IOPort(int address)
		{
			this.address = address;
		}
	}
}
