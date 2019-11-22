/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
namespace Tw.Teddysoft.Gof.Adapter.Ans
{
    public class ConfigObject
    {
        public ConfigObject()
        {
        }

		public string getKey()
		{
            return this.ToString() + "." + this.GetHashCode();
		}
    }
}
