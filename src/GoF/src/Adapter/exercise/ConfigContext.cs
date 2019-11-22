/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Adapter.Exercise
{
    public class ConfigContext
    {
        private Dictionary<string, ConfigObject> mLookup = new Dictionary<string, ConfigObject>();

		public ConfigContext()
		{
		}

		public List<ConfigObject> getAllObjects()
		{
            return new List<ConfigObject>(mLookup.Values);
		}

		public void add(ConfigObject obj)
		{
            if (!mLookup.ContainsKey(obj.getKey()))
			{
                mLookup.Add(obj.getKey(), obj);
			}
		}

		public ConfigObject get(String aKey)
		{
            ConfigObject value;
            mLookup.TryGetValue(aKey, out value);
            return value;
		}

		public void remove(ConfigObject obj)
		{
            mLookup.Remove(obj.getKey());
		}

		public void clear()
		{
            mLookup.Clear();
		}

		public void addTemplate(ConfigObject template)
		{

		}
		//....
	
    }
}
