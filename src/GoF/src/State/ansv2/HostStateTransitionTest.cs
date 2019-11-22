/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.State.Ansv2
{
    [TestFixture]
    public class HostStateTransitionTest
    {
        class DownCommand : Command
        {
            public CheckResult execute()
            {
                return CheckResult.DOWN;
            }
        }
        class UpCommand : Command
        {
            public CheckResult execute()
            {
                return CheckResult.UP;
            }
        }
        [Test]
        public void test_down_transition()
        {
            Host host = new Host(new DownCommand());
            Assert.AreEqual(Host.UP_HARD, host.getState());
            host.check();
            Assert.AreEqual(Host.DOWN_SOFT, host.getState());
            host.check();
            Assert.AreEqual(Host.DOWN_SOFT, host.getState());
            host.check();
            Assert.AreEqual(Host.DOWN_HARD, host.getState());
            host.check();
            Assert.AreEqual(Host.DOWN_HARD, host.getState());
            host.check();
            Assert.AreEqual(Host.DOWN_HARD, host.getState());
            Assert.AreEqual(3, host.getAttempt());

            host.changeState(Host.UP_SOFT);
            Assert.AreEqual(Host.UP_SOFT, host.getState());
            host.check();
            Assert.AreEqual(Host.DOWN_HARD, host.getState());
        }

        [Test]
        public void test_up_transition()
        {
            Host host = new Host(new UpCommand());
            host.changeState(Host.DOWN_HARD);
            Assert.AreEqual(Host.DOWN_HARD, host.getState());
            host.check();
            Assert.AreEqual(Host.UP_SOFT, host.getState());
            host.check();
            Assert.AreEqual(Host.UP_SOFT, host.getState());
            host.check();
            Assert.AreEqual(Host.UP_HARD, host.getState());
            host.check();
            Assert.AreEqual(Host.UP_HARD, host.getState());
            host.check();
            Assert.AreEqual(Host.UP_HARD, host.getState());
            Assert.AreEqual(3, host.getAttempt());

            host.changeState(Host.DOWN_SOFT);
            Assert.AreEqual(Host.DOWN_SOFT, host.getState());
            host.check();
            Assert.AreEqual(Host.UP_HARD, host.getState());
        }
	}
}
