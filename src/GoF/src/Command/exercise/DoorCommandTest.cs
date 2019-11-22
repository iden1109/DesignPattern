/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using NUnit.Framework;
using System.IO;
using TW.Teddysoft.src.Command.exercise;

namespace Tw.Teddysoft.Gof.Command.Exercise
{
    [TestFixture]
    public class RemoteDoorCommandTest
    {
		class MockRemoteDoor : Door
		{
			private String status = null;

			public MockRemoteDoor(String ipAddress) : base(ipAddress)
			{
			}

			public MockRemoteDoor(String ipAddress, String status) : base(ipAddress)
			{
				this.status = status;
			}

            public override String getDoorStatus()
		    {
			    return status;
		    }
	    }


        [Test]
		public void testCommand_DoorOpen()
        { 
            Door door = new MockRemoteDoor("192.168.0.1", "open");
            ICommand doorCmd = new DoorCommand(door);
            Result result = doorCmd.execute();

            Assert.AreEqual(Status.CRITICAL, result.getStatus());
            Assert.True(result.getMessage().StartsWith("門被打開"));
            Console.WriteLine(result.getMessage());
        }

		[Test]
		public void testCommand_DoorClosed()
		{
            Door door = new MockRemoteDoor("192.168.0.1", "not open");
            ICommand doorCmd = new DoorCommand(door);
            Result result = doorCmd.execute();

            Assert.AreEqual(Status.OK, result.getStatus());
            Assert.AreEqual(0, result.getMessage().Length);
            Console.WriteLine(result.getMessage());
        }


		[Test]
		public void testServer()
        {
            try
            {
                using (var consoleOut = new StringWriter())
                {
                    Console.SetOut(consoleOut);
                    Server server = new Server();
                    Door door = new MockRemoteDoor("192.168.0.1", "open");


                    ICommand doorCmd = new DoorCommand(door);
                    Client client = new Client(new DoorCommand(door));
                    server.addClient(client);
                    server.monitor();
                    Assert.AreEqual("發現問題並通知保全人員: 門被打開\r\n", consoleOut.ToString());
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
