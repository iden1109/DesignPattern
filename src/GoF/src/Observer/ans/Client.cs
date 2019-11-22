/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Collections.Generic;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public class Client : Subject
    {
        private Command checkCommand;
        private Result result = new Result(Status.PENDING);
        IList<Observer> observers = new List<Observer>();


        public void addObserver(Observer obj)
        {
            observers.Add(obj);
        }

        public void deleteObserver(Observer obj)
        {
            observers.Remove(obj);
        }

        public void notifyObserver()
        {
            foreach(Observer observer in observers)
            {
                if (null != observer)
                    observer.update(this);
            }
        }

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

    }
}
