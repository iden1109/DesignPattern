/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;
using System.IO;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    [TestFixture]
    public class ObserverTest
    {
		class MockRemoteDoor : Door
		{
			private String status = null;
			public MockRemoteDoor(String ipAddress) : base(ipAddress)
			{}
			public MockRemoteDoor(String ipAddress, String status) : base(ipAddress)
			{
				this.status = status;
			}
            public override String getDoorStatus()
		    {
			    return status;
		    }
        }

        public class MockChangeLogger : Observer
        {
            public int notifiedCount = 0;
            public void update(Subject subject)
            {
                notifiedCount++;
            }
        }

        [Test]
        public void subject_status_change_will_notify_observers()
        {
            Client client = new Client(new DoorCommand(""));
            MockChangeLogger logger1 = new MockChangeLogger();
            MockChangeLogger logger2 = new MockChangeLogger();
            MockChangeLogger logger3 = new MockChangeLogger();
            client.addObserver(logger1);
            client.addObserver(logger2);
            client.addObserver(logger3);

            client.setResult(new Result(Status.CRITICAL));
            Assert.AreEqual(1, logger1.notifiedCount);
            Assert.AreEqual(1, logger2.notifiedCount);
            Assert.AreEqual(1, logger3.notifiedCount);

            client.setResult(new Result(Status.WARRING));
            Assert.AreEqual(2, logger1.notifiedCount);
            Assert.AreEqual(2, logger2.notifiedCount);
            Assert.AreEqual(2, logger3.notifiedCount);
        }

        [Test]
        public void integration_test_door_open_will_notify_real_observers()
        {
            try
            {
                using (var consoleOut = new StringWriter())
                {
                    Console.SetOut(consoleOut);
                    Server server = new Server();
                    Door door = new MockRemoteDoor("192.168.0.1", "open");
                    Client client = new Client(new DoorCommand(door));
                    SentingAlertObserver alert = new SentingAlertObserver();
                    WritingLogObserver log = new WritingLogObserver();
                    client.addObserver(alert);
                    client.addObserver(log);
                    server.addClient(client);
                    server.monitor();
                    String expected = "發現問題並通知保全人員: 門被開啟\r\n"
                                                    + "寫資料到資料庫: 門被開啟";
                    Assert.True(consoleOut.ToString().StartsWith(expected));
                }
            }
            finally
            {
                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);
            }
        }

        [Test]
        public void integration_test_door_not_open_will_not_notify_observers()
        {
            try
            {
                using (var consoleOut = new StringWriter())
                {
                    Console.SetOut(consoleOut);
                    Server server = new Server();
                    Door door = new MockRemoteDoor("192.168.0.1", "not open");
                    Client client = new Client(new DoorCommand(door));
                    SentingAlertObserver alert = new SentingAlertObserver();
                    WritingLogObserver log = new WritingLogObserver();
                    client.addObserver(alert);
                    client.addObserver(log);
                    server.addClient(client);
                    server.monitor();
                    Assert.AreEqual("", consoleOut.ToString());
                }
            }
            finally
            {
                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);
            }
        }
    }
}
