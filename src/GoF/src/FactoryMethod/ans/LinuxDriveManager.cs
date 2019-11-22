/*
* Copyright 2017 TeddySoft Technology. 
* 
*/
using System;

namespace Tw.Teddysoft.Gof.FactoryMethod.Ans
{
    public class LinuxDriveManager : DriveManager
	{
		protected override Drive createDrive(String type, int index)
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
