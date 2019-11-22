/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Ans
{
    public class WindowsFactory : AbstractFactory
    {
        public override Drive createDrive(String type, int index)
        {
            SimpleDriveFactory driveFactory = new SimpleDriveFactory();
            return driveFactory.createWindowsDrive(type, index);
        }
        public override Process createProcess(int id)
        {
            return new WinProcess(id);
        }
        public override IOPort createIOPort(int address)
        {
            return new WinIOPort(address);
        }
        public override Monitor createMonitor(int id)
        {
            return new WinMonitor(id);
        }
    }
}
