/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public class Server
	{
        IList<Client> clients = new List<Client>();

        public void monitor()
		{
			foreach (Client client in clients)
			{
                client.setResult(client.getCheckCommand().execute());
			}
		}
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
