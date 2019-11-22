/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Adapter.Ans
{
    public class AgentModelAdapter
    {
        public AgentModelAdapter()
        {
        }

		private ConfigContext mContext = null;

		public AgentModelAdapter(ConfigContext aContext)
		{
			mContext = aContext;
		}

		public void setAgent(Agent obj)
		{
			if (null == obj)
				throw new ArgumentNullException("Agent cannot be null.");

			if (hasAgent())
			{
				mContext.remove(obj);
			}
			mContext.add(obj);
		}

		private bool hasAgent()
		{
			foreach (ConfigObject obj in mContext.getAllObjects())
			{
                if (obj.GetType() == typeof(Agent))
                    
                return true;
		    }
            return false;
        }

	    public Agent getAgent()
	    {
		    foreach (ConfigObject obj in mContext.getAllObjects())
		    {
                if (obj.GetType() == typeof(Agent))
                return (Agent)obj;
	        }
            throw new Exception("No Agent found.");
        }

		public void addAcceport(Acceptor aObj)
		{
			mContext.add(aObj);
		}

		public Acceptor getAcceptor(String key)
		{
			return (Acceptor)mContext.get(key);
		}

	public List<Acceptor> getAcceptors()
	{
		List<Acceptor> result = new List<Acceptor>();
		foreach (ConfigObject obj in mContext.getAllObjects())
		{
                if (obj.GetType() == typeof(Acceptor))
	                result.Add((Acceptor)obj);
	    }
        return result;
    }
    
    //... other methods

    }
}
