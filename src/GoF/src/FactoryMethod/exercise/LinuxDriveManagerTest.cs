/*
* Copyright 2017 TeddySoft Technology. 
* 
*/
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.FactoryMethod.Exercise
{
    [TestFixture]
    public class LinuxDriveManagerTest
	{
    	public void createLinuxUSBDrive()
		{
            //TODO
            DriveManager dm = new LinuxDriveManager();
            Drive drive = dm.getDrive("USB", 0);

            Assert.AreEqual(typeof(LinuxUSBDrive), drive.GetType());
            Assert.AreNotEqual(typeof(WinSATADrive), drive.GetType());
            Assert.AreNotEqual(typeof(WinUSBDrive), drive.GetType());
            Assert.AreNotEqual(typeof(LinuxSATADrive), drive.GetType());
        }

		[Test]
	    public void createLinuxSATADrive()
		{
            //TODO
            DriveManager dm = new LinuxDriveManager();
            Drive drive = dm.getDrive("SATA", 0);

            Assert.AreEqual(typeof(LinuxSATADrive), drive.GetType());
            Assert.AreNotEqual(typeof(WinUSBDrive), drive.GetType());
            Assert.AreNotEqual(typeof(LinuxUSBDrive), drive.GetType());
            Assert.AreNotEqual(typeof(WinSATADrive), drive.GetType());
        }


		[Test]
		public void createUnsupportedWinSASDrive()
		{
            //TODO
            DriveManager dm = new LinuxDriveManager();
            try
            {
                Drive drive = dm.getDrive("SAS", 0);
                Assert.Fail("Infessible path.");
            }
            catch (Exception e)
            {
                Assert.True(true, "Unsupported drive type 'SAS' throws a RuntimeException");
            }
        }
    }
}
