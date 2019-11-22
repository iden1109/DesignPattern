/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Command.Exercise
{
    public class Server 
    {
	    private IList<Client> _clients = new List<Client>();

        public void monitor(){
            foreach (Client client in _clients)
            {
                client.setResult(client.getCheckCommand().execute());
                if (client.getResult().getStatus() != Status.OK)
                {
                    sendAlert(client.getResult().getMessage());
                }
            }
           
        }
        public void sendAlert(String msg){
            Console.WriteLine("發現問題並通知保全人員: " + msg);
        }

        public void addClient(Client client)
        {
            this._clients.Add(client);
        }

        public void remoteClient(Client client)
        {
            this._clients.Remove(client);
        }
	   
    }

}
