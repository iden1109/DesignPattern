/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using TW.Teddysoft.src.Observer.exercise;

namespace Tw.Teddysoft.Gof.Observer.Exercise
{
    class WritingLogObserver : IObserver
    {
        public void update(ISubject subject)
        {
            Client client = (Client)subject;
            if (Status.OK != client.getResult().getStatus())
                Console.WriteLine("寫資料到資料庫: " + client.getResult().getMessage());
        }
    }
}