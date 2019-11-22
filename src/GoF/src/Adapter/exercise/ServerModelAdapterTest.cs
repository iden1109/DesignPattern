/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.Adapter.Exercise
{
    [TestFixture]
    public class ServerModelAdapterTest
    {
		private ServerModelAdapter adapter;

		[SetUp]
	    public void setup()
		{
			adapter = new ServerModelAdapter(new ConfigContext());
		}

		[Test]
	    public void can_add_multiple_hosts()
		{
			adapter.addHost(new Host());
			adapter.addHost(new Host());
			adapter.addHost(new Host());
            Assert.AreEqual(3, adapter.getHosts().Count);

		}

		[Test]
	    public void can_add_multiple_contracts()
		{
			adapter.addContact(new Contact());
			adapter.addContact(new Contact());
			adapter.addContact(new Contact());
            Assert.AreEqual(3, adapter.getContacts().Count);
		}
    }
}
