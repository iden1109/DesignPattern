/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Observer.Exercise
{
    public class Server
	{
        IList<Client> clients = new List<Client>();

        public void monitor()
		{
			foreach (Client client in clients)
			{
                client.setResult(client.getCheckCommand().execute());
				//if (Status.OK != client.getResult().getStatus())
				//	sendAlert(client.getResult().getMessage());
			}
		}

		//public void sendAlert(String msg)
		//{
  //          Console.WriteLine("發現問題並通知保全人員: " + msg);
		//}

		public void addClient(Client client)
		{
			clients.Add(client);
		}

		public void removeCommand(Client client)
		{
            clients.Remove(client);
		}
	}
}
