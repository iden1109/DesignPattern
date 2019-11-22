/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;

namespace Tw.Teddysoft.Gof.Composite.Ans
{
    public class LineBullet : Bullet
    {
		public override void fire()
		{
            Console.WriteLine("發射直線子彈.");
		}
    }
}
