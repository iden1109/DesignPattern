/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Exercise
{
    public abstract class Process
	{
		private int id;
		public Process(int id)
		{
			this.id = id;
		}
	}
}
