/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.SimpleFactory.Ans
{
    [TestFixture]
    public class SimpleDriveFactoryTest
	{
		[Test]
		public void create_SATADrive_via_SimpleDriveFactory()
		{
            Assert.AreEqual(typeof(SATADrive), new SimpleDriveFactory().createDrive("SATA", 0).GetType());
	    }

	    [Test]
		public void create_USBDrive_via_SimpleDriveFactory()
	    {
            Assert.AreEqual(typeof(USBDrive), new SimpleDriveFactory().createDrive("USB", 0).GetType());
	    }

		[Test]
		public void create_unsported_drive_SASDrive_via_SimpleDriveFactory_will_thorw_a_runtime_exception()
		{

		    try
		    {
                new SimpleDriveFactory().createDrive("SAS", 0);
		        Assert.Fail();
		    }
		    catch (Exception e)
		    {
                Assert.AreEqual("Unsupported drive type: SAS", e.Message);
		    }
		}
    }
}
