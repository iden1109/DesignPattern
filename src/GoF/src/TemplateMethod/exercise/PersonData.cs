/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.TemplateMethod.Exercise
{
    public class PersonData
	{
		private int _HP = 0;
		private String _name = null;

		public int getHP()
		{
			return _HP;
		}

		public void setHP(int aHP)
		{
			this._HP = aHP;
		}

		public String getName()
		{
			return _name;
		}

		public void setName(String aName)
		{
			this._name = aName;
		}
	}
}
