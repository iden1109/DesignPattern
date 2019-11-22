/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.Facade.Exercise
{
    public class WhenTestingClient
    {
		[Test]
	    public void testClientA() {
			ClientA clientA = new ClientA(100);
			clientA.copy(12);
			Assert.AreEqual(88, clientA.getNumberOfPapers());
	    }

		[Test]
		public void testClientBOK()
		{
			ClientB clientB = new ClientB(20);
			Assert.AreEqual("", clientB.copy());
		}

		[Test]
		public void testClientBError()
		{
			ClientB clientB = new ClientB(0);
			Assert.AreEqual("Scanner error. No paper!", clientB.copy());
		}
    }
}
