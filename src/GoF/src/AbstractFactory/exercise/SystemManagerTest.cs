/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.AbstractFactory.Exercise
{
    [TestFixture]
    public class SystemManagerTest
    {
        [Test]
	    public void usingWindowsFactory()
		{
            //TODO
            SystemManager sm = new SystemManager(new WindowsFactory());
            Assert.AreEqual(typeof(WinUSBDrive), sm.getDrive("USB", 0).GetType());
            Assert.AreEqual(typeof(WinIOPort), sm.getIOPort(0x00ff).GetType());
            Assert.AreEqual(typeof(WinProcess), sm.getProcess(3388).GetType());
            Assert.AreEqual(typeof(WinMonitor), sm.getMonitor(1).GetType());
        }

		[Test]
	    public void usingLinuxFactory()
		{
            
            SystemManager sm = new SystemManager(new LinuxFactory());
            Assert.AreEqual(typeof(LinuxUSBDrive), sm.getDrive("USB", 0).GetType());
            Assert.AreEqual(typeof(LinuxIOPort), sm.getIOPort(0x00ff).GetType());
            Assert.AreEqual(typeof(LinuxProcess), sm.getProcess(3388).GetType());
            Assert.AreEqual(typeof(LinuxMonitor), sm.getMonitor(1).GetType());
        }
    }
}
