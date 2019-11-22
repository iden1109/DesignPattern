/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public class WritingLogObserver : Observer
    {
        public void update(Subject subject)
        {
            Client client = (Client)subject;
            if (Status.OK != client.getResult().getStatus())
                Console.WriteLine("寫資料到資料庫: " +
                        client.getResult().getMessage() +
                        " 在: " + DateTime.Now);
        }
    }
}
