/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Adapter.Exercise
{
    public class ServerModelAdapter
    {
        private ConfigContext mContext = null;

        public ServerModelAdapter()
        {
        }

		public ServerModelAdapter(ConfigContext aContext)
		{
			mContext = aContext;
		}
		public void addHost(Host aObj)
		{
			mContext.add(aObj);
		}

		public Host getHost(String key)
		{
			return (Host)mContext.get(key);
		}

		public List<Host> getHosts()
		{
			List<Host> result = new List<Host>();
			foreach (ConfigObject obj in mContext.getAllObjects())
			{
                if (obj.GetType() == typeof(Host))
                result.Add((Host)obj);
		    }
            return result;
        }

		public void addContact(Contact aObj)
		{
			mContext.add(aObj);
		}

		public Contact getContact(String key)
		{
			return (Contact)mContext.get(key);
		}

		public List<Contact> getContacts()
		{
			List<Contact> result = new List<Contact>();
			foreach (ConfigObject obj in mContext.getAllObjects())
			{
                if (obj.GetType() == typeof(Contact))
	                result.Add((Contact)obj);
		    }
	        return result;
	    }
    
        //... other methods

    }
}
