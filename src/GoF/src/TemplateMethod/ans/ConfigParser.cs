/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.TemplateMethod.Ans
{
    public abstract class ConfigParser
	{
		protected PersonData mPData = null;

		public PersonData doParse()
		{
			readData();
			parseToken();
			buildModel();
			validate();
			return mPData;
		}

		abstract protected void readData();
		abstract protected void parseToken();
		abstract protected void buildModel();
		abstract protected void validate();
	}
}
