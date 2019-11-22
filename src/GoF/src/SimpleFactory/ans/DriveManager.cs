/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.SimpleFactory.Ans
{
    public class DriveManager
	{
        private SimpleDriveFactory factory;

        public DriveManager(SimpleDriveFactory factory)
        {
            this.factory = factory;
        }

	    public Drive getDrive(String type, int index){
	        Drive drive = factory.createDrive(type, index);
	        drive.updateFreeSpace();
	        drive.doQuickSMARTCheck();
	        return drive;
	    }
    }
}
