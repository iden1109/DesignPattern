﻿/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Command.Ans
{
    public class Client
    {
        private Command checkCommand;
        private Result result = new Result(Status.PENDING);

        public Client(Command command)
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
