/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Ans
{
    public class SystemManager
    {
        AbstractFactory factory = null;
        public SystemManager(AbstractFactory factory)
        {
            this.factory = factory;
        }
        public Drive getDrive(String type, int index)
        {
            Drive drive = factory.createDrive(type, index);
            drive.updateFreeSpace();
            drive.doQuickSMARTCheck();
            return drive;
        }
        public IOPort getIOPort(int address)
        {
            IOPort ioPort = factory.createIOPort(address);
            // do something to the IOPort
            return ioPort;
        }
        public Process getProcess(int id)
        {
            Process process = factory.createProcess(id);
            // do something to the process
            return process;
        }
        public Monitor getMonitor(int id)
        {
            Monitor monitor = factory.createMonitor(id);
            // do something to the monitor
            return monitor;
        }
    }
}
