/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;

namespace Tw.Teddysoft.Gof.Composite.Ans2
{
    public class ShotgunBullet : Bullet
	{
		public override void fire()
		{
            Console.WriteLine("發射散彈.");
		}
    }
}
