/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
namespace Tw.Teddysoft.Gof.Adapter.Exercise
{
    public class Contact : ConfigObject
    {
        public Contact()
        {
        }

		private String email;

		public void setEmail(String email)
		{
			this.email = email;
		}

		public String getEmail()
		{
			return email;
		}
    }
}



