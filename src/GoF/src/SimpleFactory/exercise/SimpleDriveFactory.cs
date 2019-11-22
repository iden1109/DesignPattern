using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Teddysoft.Gof.SimpleFactory.Exercise;

namespace Tw.Teddysoft.Gof.SimpleFactory.Exercise
{
    public class SimpleDriveFactory
    {
        public Drive createDrive(string type, int index)
        {
            Drive drive = null;
            switch (type)
            {
                case "SATA":
                    drive = new SATADrive(index);
                    break;
                case "USB":
                    drive = new USBDrive(index);
                    break;
                default:
                    throw new Exception
                    ("Unsupported drive type: " + type);
            }
            return drive;
        }
    }
}
