/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Ans
{
    public abstract class AbstractFactory
    {
        public abstract Drive createDrive(String type, int index);
        public abstract Process createProcess(int id);
        public abstract IOPort createIOPort(int address);
        public abstract Monitor createMonitor(int id);
        // more creational methods....
    }
}
