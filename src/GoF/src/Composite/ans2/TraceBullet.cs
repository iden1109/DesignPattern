/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;

namespace Tw.Teddysoft.Gof.Composite.Ans2
{
    public class TraceBullet : Bullet
	{
		public override void fire()
		{
            Console.WriteLine("發射追蹤子彈.");
		}
    }
}
