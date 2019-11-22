/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.TemplateMethod.Ans
{
    public class FileConfigParser : ConfigParser
	{
		private String fileName = null;

		public FileConfigParser(String fileName)
		{
			this.fileName = fileName;
		}

		protected override void readData()
		{
            Console.WriteLine("Read config data "
					+ "from file: " + fileName);
		}

		protected override void parseToken()
		{
			Console.WriteLine("parseToken...");
		}

		protected override void buildModel()
		{
			mPData = new PersonData();
			mPData.setName("Teddy");
			mPData.setHP(100);
		}

		protected override void validate()
		{
			Console.WriteLine("validate config data "
					+ "built from file...");
		}
	}
}
