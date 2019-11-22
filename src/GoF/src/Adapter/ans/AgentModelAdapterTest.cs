/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;

namespace Tw.Teddysoft.Gof.Adapter.Ans
{
    [TestFixture]
    public class AgentModelAdapterTest
    {
		private AgentModelAdapter adapter;

		[SetUp]
	    public void setup()
		{
			adapter = new AgentModelAdapter(new ConfigContext());
		}

		[Test]
	    public void can_add_multiple_acaptors()
		{
			adapter.addAcceport(new Acceptor());
			adapter.addAcceport(new Acceptor());
			adapter.addAcceport(new Acceptor());
            Assert.AreEqual(3, adapter.getAcceptors().Count);
		}

		[Test]
	    public void can_set_an_agent()
		{
			Agent agent = new Agent();
			adapter.setAgent(agent);
            Assert.AreEqual(agent, adapter.getAgent());
		}

		[Test]
	    public void invoke_getAgent_will_throw_an_exception_if_not_call_setAgent_first()
		{
			Agent agent = new Agent();
			try
			{
				Assert.AreEqual(agent, adapter.getAgent());
			}
			catch (Exception e)
			{
                Assert.AreEqual("No Agent found.", e.Message);
			}
		}
    }
}
