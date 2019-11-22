/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;
using TW.Teddysoft.src.Observer.exercise;

namespace Tw.Teddysoft.Gof.Observer.Exercise
{
    public class Client : ISubject
    {
        private Command checkCommand;
        private Result result = new Result(Status.PENDING);
        private List<IObserver> _list = new List<IObserver>();

        public Client(Command command)
        {
            this.checkCommand = command;
        }
        public void setResult(Result result)
        {
            this.result = result;
            notifyObserver();
        }
        public Result getResult()
        {
            return result;
        }
        public void setCheckCommand(Command command)
        {
            this.checkCommand = command;
        }
        public Command getCheckCommand()
        {
            return checkCommand;
        }

        public void addObserver(IObserver observer)
        {
            this._list.Add(observer);
        }

        public void deleteObserver(IObserver observer)
        {
            this._list.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach(IObserver observer in this._list)
            {
                if (observer != null)
                    observer.update(this);
            }
        }
    }
}
