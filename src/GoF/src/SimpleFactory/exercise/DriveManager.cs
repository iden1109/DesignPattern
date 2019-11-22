/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.SimpleFactory.Exercise
{
    public class DriveManager
	{
		Drive getDrive(String type, int index)
		{
			Drive drive = null;

			

			drive.updateFreeSpace();
			drive.doQuickSMARTCheck();

			return drive;
		}
	}
}
