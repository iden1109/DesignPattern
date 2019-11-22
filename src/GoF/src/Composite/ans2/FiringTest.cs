/*
 * Copyright 2017 TeddySoft Technology. 
 *
 */
using System;
using NUnit.Framework;
using System.IO;

namespace Tw.Teddysoft.Gof.Composite.Ans2
{
    [TestFixture]
    public class FiringTest
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
        public void testFiringClip()
        {
            Clip rootClip = new Clip();
            Clip childClip = new Clip();
            childClip.add(new TraceBullet());
            childClip.add(new LineBullet());
            childClip.add(new TraceBullet());
            rootClip.add(childClip);
            rootClip.fire();
            String expected = "發射追蹤子彈.\r\n"
                        + "發射直線子彈.\r\n"
                        + "發射追蹤子彈.\r\n";
            Assert.AreEqual(expected,
                    consoleOut.ToString());
        }

        [Test]
        public void testFiringClipWithBullet()
        {
            Clip rootClip = new Clip();
            Clip childClip = new Clip();
            childClip.add(new TraceBullet());
            childClip.add(new TraceBullet());
            childClip.add(new TraceBullet());
            rootClip.add(new LineBullet());
            rootClip.add(childClip);
            rootClip.add(new LineBullet());
            rootClip.fire();
            String expected = "發射直線子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射直線子彈.\r\n";
            Assert.AreEqual(expected,
                    consoleOut.ToString());
        }

        [Test]
        public void testShotgunBullet()
        {
            Clip rootClip = new Clip();
            Clip childClip = new Clip();
            childClip.add(new TraceBullet());
            childClip.add(new TraceBullet());
            childClip.add(new TraceBullet());
            rootClip.add(new LineBullet());
            rootClip.add(childClip);
            rootClip.add(new LineBullet());
            rootClip.add(new ShotgunBullet());
            rootClip.add(new ShotgunBullet());

            rootClip.fire();
            String expected = "發射直線子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射追蹤子彈.\r\n"
                    + "發射直線子彈.\r\n"
                    + "發射散彈.\r\n"
                    + "發射散彈.\r\n";
            Assert.AreEqual(expected,
                    consoleOut.ToString());
        }
    }

}
