/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.FactoryMethod.Ans
{
    public class GenericDriveManager
    {
        public Drive getDrive<T>(T type, int index) where T : Drive
        {
            Drive drive;
            try
            {
                drive = (T)Activator.CreateInstance(typeof(T), new object[] { index, });
                drive.updateFreeSpace();
			    drive.doQuickSMARTCheck();
		    } catch (Exception e) {
			    throw new Exception("Cannot create drive.", e);
            }
		    return drive;
	    }
    }
}
