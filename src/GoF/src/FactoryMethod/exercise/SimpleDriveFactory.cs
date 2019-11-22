/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.FactoryMethod.Exercise
{
    public class SimpleDriveFactory
    {
        public Drive createDrive(String type, int index)
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
