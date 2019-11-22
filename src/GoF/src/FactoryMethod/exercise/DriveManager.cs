/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.FactoryMethod.Exercise
{
    public abstract class DriveManager
    { 
        public DriveManager()
        {
        }

	    public Drive getDrive(String type, int index){
	        Drive drive = createDrive(type, index);
	        drive.updateFreeSpace();
	        drive.doQuickSMARTCheck();
	        return drive;
	    }

        protected abstract Drive createDrive(String type, int index);
    }
}
