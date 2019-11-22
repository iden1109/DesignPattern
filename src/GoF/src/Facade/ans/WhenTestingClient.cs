/*
* Copyright 2017 TeddySoft Technology. 
* 
*/
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.Facade.Ans
{
    [TestFixture]
    public class WhenTestingClient
    {
		[Test]
	    public void testClientA(){

		MultiFunctionPrinter mfp = new MultiFunctionPrinter(new Printer(100), new Scanner(), new Fax(), new LCD());
		    ClientA clientAe = new ClientA(mfp);
		    clientAe.copy(12);
		    Assert.AreEqual(88, clientAe.getNumberOfPapers());
	    }

		[Test]
		public void testClientBOK()
		{
			MultiFunctionPrinter mfp = new MultiFunctionPrinter(new Printer(20), new Scanner(), new Fax(), new LCD());
			ClientB clientB = new ClientB(mfp);
			Assert.AreEqual("", clientB.copy());
		}

		[Test]
		public void testClientBError()
		{
			MultiFunctionPrinter mfp = new MultiFunctionPrinter(new Printer(0), new Scanner(), new Fax(), new LCD());
			ClientB clientB = new ClientB(mfp);
			Assert.AreEqual("Scanner error. No paper!", clientB.copy());
		}
    }
}
