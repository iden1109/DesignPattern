using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.FactoryMethod.Exercise
{
    public class LinuxDriveManager : DriveManager
    {
        public LinuxDriveManager()
        {

        }

        protected override Drive createDrive(string type, int index)
        {
            Drive drive = null;
            switch (type)
            {
                case "SATA":
                    drive = new LinuxSATADrive(index);
                    break;
                case "USB":
                    drive = new LinuxUSBDrive(index);
                    break;
                default:
                    throw new Exception
                    ("Unsupported drive type: " + type);
            }
            return drive;
        }
    }
}
