/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;
using System.IO;

namespace Tw.Teddysoft.Gof.Strategy.Ans
{
    public class DriveManagerTest
    {
        private StringWriter consoleOut;
        [SetUp]
        public void setUp()
        {
            consoleOut = new StringWriter();
            Console.SetOut(consoleOut);
        }
        [TearDown]
        public void tearDown()
        {
            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
        }

        [Test]
        public void demo_a_client_of_drive_manager()
        {
            DriveManager dm = new DriveManager();

            dm.format("Ntfs");
            Assert.AreEqual("格式化為NTFS", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            dm.format("Fat32");
            Assert.AreEqual("格式化為FAT32", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            dm.format("Fat");
            Assert.AreEqual("格式化為FAT", consoleOut.ToString().Trim());
        }
	}
}
