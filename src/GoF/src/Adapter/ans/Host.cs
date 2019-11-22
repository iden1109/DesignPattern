/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
namespace Tw.Teddysoft.Gof.Adapter.Ans
{
    public class Host : ConfigObject
    {
		private String ip;

		public Host()
		{
		}

		public void setIPAddress(String ip)
		{
			this.ip = ip;
		}

		public String getIPAddress()
		{
			return ip;
		}
    }
}
