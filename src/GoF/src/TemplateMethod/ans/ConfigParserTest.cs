/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;
using System.IO;

namespace Tw.Teddysoft.Gof.TemplateMethod.Ans
{
    [TestFixture]
    public class ConfigParserTest
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
        public void testFileConfigParser()
        {
            ConfigParser fileParser = new
                    FileConfigParser("C:\\config.ini");
            PersonData fpd = fileParser.doParse();
            Assert.AreEqual("Teddy", fpd.getName());
            Assert.AreEqual(100, fpd.getHP());
            String expected = "Read config data from file: "
                    + "C:\\config.ini\r\n"
                    + "parseToken...\r\n"
                    + "validate config data built from file...\r\n";
            Assert.AreEqual(expected, consoleOut.ToString());
        }
        [Test]
        public void testDBConfigParser()
        {
            ConfigParser dbParser = new
                    DbConfigParser("http://127.0.0.1/hsql/mydb");
            PersonData dbpd = dbParser.doParse();
            Assert.AreEqual("Kay", dbpd.getName());
            Assert.AreEqual(100, dbpd.getHP());
            String expected = "Read config data from database: "
                    + "http://127.0.0.1/hsql/mydb\r\n"
                    + "parseToken...\r\n"
                    + "validate config data built from database...\r\n";
            Assert.AreEqual(expected, consoleOut.ToString());
        }
	}
}
