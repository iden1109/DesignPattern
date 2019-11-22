/*
* Copyright 2017 TeddySoft Technology. 
* 
*/
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.FactoryMethod.Ans
{
    [TestFixture]
    public class WinDriveManagerTest
    {
		[Test]
	    public void createWinUSBDrive()
		{
			DriveManager dm = new WinDriveManager();
			Drive drive = dm.getDrive("USB", 0);

            Assert.AreEqual(typeof(WinUSBDrive), drive.GetType());
            Assert.AreNotEqual(typeof(WinSATADrive), drive.GetType());
            Assert.AreNotEqual(typeof(LinuxUSBDrive), drive.GetType());
            Assert.AreNotEqual(typeof(LinuxSATADrive), drive.GetType());
        }

		[Test]
		public void createWinSATADrive()
		{
			DriveManager dm = new WinDriveManager();
			Drive drive = dm.getDrive("SATA", 0);

            Assert.AreEqual(typeof(WinSATADrive), drive.GetType());
			Assert.AreNotEqual(typeof(WinUSBDrive), drive.GetType());
			Assert.AreNotEqual(typeof(LinuxUSBDrive), drive.GetType());
			Assert.AreNotEqual(typeof(LinuxSATADrive), drive.GetType());
	    }

	    [Test]
		public void createUnsupportedWinSASDrive()
	    {
		    DriveManager dm = new WinDriveManager();
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
