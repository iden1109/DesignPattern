/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Composite.Exercise
{
    public class Clip : Weapon
	{
        IList<Weapon> weaponList = new List<Weapon>();

        public override bool add(Weapon weapon)
        {
            try
            {
                weaponList.Add(weapon);
                return true;
            }catch (Exception)
            {
                return false;
            }
        }

        internal void addBullet(Bullet bullet)
        {
            weaponList.Add(bullet);
        }

        internal void addClip(Clip childClip)
        {
            weaponList.Add(childClip);
        }

        public override bool remove(Weapon weapon)
        {
            try
            {
                weaponList.Remove(weapon);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override Weapon getChild(int index)
        {
            return weaponList[index];
        }

        public override void fire()
        {
            foreach (Weapon weapon in weaponList)
            {
                weapon.fire();
            }
        }
    }
}
