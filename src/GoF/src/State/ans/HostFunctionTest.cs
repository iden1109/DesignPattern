/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;
using System.IO;
using System.Text;

namespace Tw.Teddysoft.Gof.State.Ans
{
    [TestFixture]
    public class HostFunctionTest
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
        public void test_up_hard_state()
        {
            Host host = new Host(null);
            host.powerOn();
            Assert.AreEqual("Cannot power on under up hard state.", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            host.powerOff();
            Assert.AreEqual("Power off gracefully.", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            Assert.AreEqual("Diagnostic via the remote agent.", host.diagnostic());
        }
        [Test]
        public void test_up_soft_state()
        {
            Host host = new Host(null);
            host.changeState(Host.UP_SOFT);

            host.powerOn();
            Assert.AreEqual("Cannot power on under up soft state.", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            host.powerOff();
            Assert.AreEqual("Power off after 60 second(s).", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            Assert.AreEqual("Diagnostic via the remote agent.", host.diagnostic());
        }

        [Test]
        public void test_down_hard_state()
        {
            Host host = new Host(null);
            host.changeState(Host.DOWN_HARD);

            host.powerOn();
            Assert.AreEqual("Power On.", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();
                
            host.powerOff();
            Assert.AreEqual("Cannot power off under down hard state.", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            Assert.AreEqual("Diagnostic via IPMI.", host.diagnostic());
        }
        [Test]
        public void test_down_soft_state()
        {
            Host host = new Host(null);
            host.changeState(Host.DOWN_SOFT);

            host.powerOn();
            Assert.AreEqual("Cannot power on under down soft state.", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            host.powerOff();
            Assert.AreEqual("Cannot power off under down soft state.", consoleOut.ToString().Trim());
            consoleOut.GetStringBuilder().Clear();

            Assert.AreEqual("Diagnostic via IPMI.", host.diagnostic());
        }
	}
}
