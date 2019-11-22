/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Composite.Ans2
{
    public class TraceBulletClip : Clip
	{
		IList<Weapon> list = new List<Weapon>();

        public override bool add(Weapon weapon)
	    {
            if (weapon is TraceBullet){
                list.Add(weapon);
                return true;
            }
	        else
                throw new Exception("只能裝填追蹤子彈或追蹤彈匣，但卻裝填 :"
                            + weapon.ToString());
        }
    }
}
