/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using TW.Teddysoft.src.Command.exercise;

namespace Tw.Teddysoft.Gof.Command.Exercise
{
    public class Client
    {
        private ICommand checkCommand;
        private Result result = new Result(Status.PENDING);

        public Client(ICommand command)
        {
            this.checkCommand = command;
        }
        public void setResult(Result result)
        {
            this.result = result;
        }
        public Result getResult()
        {
            return result;
        }
        public void setCheckCommand(ICommand command)
        {
            this.checkCommand = command;
        }
        public ICommand getCheckCommand()
        {
            return checkCommand;
        }
    }
}
