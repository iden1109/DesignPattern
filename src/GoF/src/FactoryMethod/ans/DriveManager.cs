/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.FactoryMethod.Ans
{
    public abstract class DriveManager
	{
		public Drive getDrive(String type, int index)
		{
			Drive drive = createDrive(type, index);

			drive.updateFreeSpace();
			drive.doQuickSMARTCheck();

			return drive;
		}

		abstract protected Drive createDrive(String type, int index);
	}
}
