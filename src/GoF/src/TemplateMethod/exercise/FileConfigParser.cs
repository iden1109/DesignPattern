using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Teddysoft.Gof.TemplateMethod.Exercise;

namespace TW.Teddysoft.src.TemplateMethod.exercise
{
    public class FileConfigParser : ConfigParser
    {
        private string _fileName = null;

        public FileConfigParser(string fileName)
        {
            this._fileName = fileName;
        }

        protected override PersonData buildModel()
        {
            mPData = new PersonData();
            mPData.setName("Teddy");
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
