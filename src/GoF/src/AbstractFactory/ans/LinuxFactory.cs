/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Ans
{
    public class LinuxFactory : AbstractFactory
    {

        public override Drive createDrive(String type, int index)
        {
            SimpleDriveFactory driveFactory = new SimpleDriveFactory();
            return driveFactory.createLinuxDrive(type, index);
        }
        public override Process createProcess(int id)
        {
            return new LinuxProcess(id);
        }
        public override IOPort createIOPort(int address)
        {
            return new LinuxIOPort(address);
        }
        public override Monitor createMonitor(int id)
        {
            return new LinuxMonitor(id);
        }
    }
}
