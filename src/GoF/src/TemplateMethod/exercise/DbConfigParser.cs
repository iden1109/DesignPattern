/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.TemplateMethod.Exercise
{
    class DbConfigParser : ConfigParser
    {
        private string _fileName;

        public DbConfigParser(string v)
        {
            this._fileName = v;
        }

        protected override PersonData buildModel()
        {
            mPData = new PersonData();
            mPData.setName("Kay");
            mPData.setHP(100);
            return mPData;
        }

        protected override void readConfig()
        {
            Console.WriteLine("Read config data from file: "
                    + _fileName + "\r\n"
                    + "parseToken...\r\n"
                    + "validate config data built from file...\r\n");
        }
    }
}