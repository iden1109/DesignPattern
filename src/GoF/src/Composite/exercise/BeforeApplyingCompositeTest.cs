/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using NUnit.Framework;
using System.IO;

namespace Tw.Teddysoft.Gof.Composite.Exercise
{
    [TestFixture]
    public class BeforeApplyingCompositeTest
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
        public void testFiringClip()
        {
            Clip rootClip = new Clip();
            Clip childClip = new Clip();
            childClip.addBullet(new TraceBullet());
            childClip.addBullet(new LineBullet());
            childClip.addBullet(new TraceBullet());
            rootClip.addClip(childClip);
            rootClip.fire();
            String expected = "發射追蹤子彈.\r\n"
                        + "發射直線子彈.\r\n"
                        + "發射追蹤子彈.\r\n";
            Assert.AreEqual(expected,
                consoleOut.ToString());
        }
        [Test]
        public void testFiringBullet()
        {
            new LineBullet().fire();
            new TraceBullet().fire();
            new LineBullet().fire();
            String expected = "發射直線子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射直線子彈.\r\n";
            Assert.AreEqual(expected,
                consoleOut.ToString());
        }

        [Test]
        public void testFiringClipWithBullet()
        {
            Clip rootClip = new Clip();
            Clip childClip = new Clip();
            childClip.addBullet(new TraceBullet());
            childClip.addBullet(new TraceBullet());
            childClip.addBullet(new TraceBullet());
            rootClip.addBullet(new LineBullet());
            rootClip.addClip(childClip);
            rootClip.addBullet(new LineBullet());
            rootClip.fire();
            String expected = "發射直線子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射直線子彈.\r\n";
            Assert.AreEqual(expected,
                consoleOut.ToString());
        }
    }
}
