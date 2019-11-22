using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.FactoryMethod.Exercise
{
    public class WinDriveManager : DriveManager
    {
        private SimpleDriveFactory factory;

        public WinDriveManager()
        {
        }

        protected override Drive createDrive(string type, int index)
        {
            Drive drive = null;
            switch (type)
            {
                case "SATA":
                    drive = new WinSATADrive(index);
                    break;
                case "USB":
                    drive = new WinUSBDrive(index);
                    break;
                default:
                    throw new Exception
                    ("Unsupported drive type: " + type);
            }
            return drive;
        }
    }
}
