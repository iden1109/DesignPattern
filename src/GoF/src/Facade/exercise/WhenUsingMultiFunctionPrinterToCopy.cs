﻿﻿/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.Facade.Exercise
{
    [TestFixture]
    public class WhenUsingMultiFunctionPrinterToCopy
    {

        Printer printer;
		private MultiFunctionPrinter mfp;

		//TODO
		
        [SetUp]
	    public void setup()
		{
			printer = new Printer();
			mfp = new MultiFunctionPrinter(printer, new Scanner(), new Fax(), new LCD());
		}

		[Test]
	    public void can_copy_when_there_is_one_paper()
		{
			printer.addPaper(new Paper());
			Assert.AreEqual(true, mfp.copy());
			Assert.AreEqual(0, mfp.getNumberOfPapers());
		}

		[Test]
	    public void can_copy_10_times_when_there_are_100_papers()
		{
			mfp = new MultiFunctionPrinter(new Printer(100), new Scanner(), new Fax(), new LCD());
			for (int i = 0; i < 10; i++)
				Assert.AreEqual(true, mfp.copy());
			Assert.AreEqual(90, mfp.getNumberOfPapers());
		}

		[Test]
	    public void cannot_copy_when_no_paper()
		{
			Assert.AreEqual(false, mfp.copy());
			Assert.AreEqual("Scanner error. No paper!", mfp.getLCDMessage());
		}

		[Test]
	    public void cannot_copy_when_run_out_of_paper()
		{
			printer.addPaper(new Paper());
			Assert.AreEqual(true, mfp.copy());
			Assert.AreEqual(false, mfp.copy());
			Assert.AreEqual("Scanner error. No paper!", mfp.getLCDMessage());
		}

		[Test]
	    public void cannot_copy_with_bad_scanner()
		{
			mfp = new MultiFunctionPrinter(printer, new BadScanner(), new Fax(), new LCD());
			printer.addPaper(new Paper());

			Assert.AreEqual(false, mfp.copy());
			Assert.AreEqual("Scanner error: Internal error.", mfp.getLCDMessage());
		}
		

		class BadScanner : Scanner
		{
			public override void warmup()
			{
				throw new ScannerException("Internal error.");
			}
		}

    }
}