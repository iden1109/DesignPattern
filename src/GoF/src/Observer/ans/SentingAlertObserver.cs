/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public class SentingAlertObserver : Observer
    {
        public void update(Subject subject)
        {
            Client client = (Client)subject;
            if (Status.OK != client.getResult().getStatus())
                Console.WriteLine("發現問題並通知保全人員: " +
                        client.getResult().getMessage());
        }
    }
}
