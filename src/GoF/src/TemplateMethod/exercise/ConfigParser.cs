/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.TemplateMethod.Exercise
{
    public abstract class ConfigParser
	{
		protected PersonData mPData = null;

		public PersonData doParse()
		{
			readConfig();
			parseToken();
			mPData = buildModel();
			validate();
			return mPData;
		}

        protected abstract void readConfig();
		private void parseToken() { }
        protected abstract PersonData buildModel();
		private void validate() { }
	}
}
