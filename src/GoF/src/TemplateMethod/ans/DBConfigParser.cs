﻿/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.TemplateMethod.Ans
{
    public class DbConfigParser : ConfigParser
	{
		private String connStr = null;

		public DbConfigParser(String connStr)
		{
			this.connStr = connStr;
		}

		protected override void readData()
		{
            Console.WriteLine("Read config data "
					+ "from database: " + connStr);
		}

		protected override void parseToken()
		{
			Console.WriteLine("parseToken...");
		}

		protected override void buildModel()
		{
			mPData = new PersonData();
			mPData.setName("Kay");
			mPData.setHP(100);
		}

		protected override void validate()
		{
			Console.WriteLine("validate config data "
					+ "built from database...");
		}
	}
}
