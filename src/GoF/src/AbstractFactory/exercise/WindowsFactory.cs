/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Exercise
{
    class WindowsFactory : IFactory
    {
        public WindowsFactory()
        {
        }

        public Drive createDrive(string type, int index)
        {
            Drive drive = null;
            switch (type)
            {
                case "SATA":
                    drive = new WinSATADrive(index);
                    break;
                case "USB":
                    drive = new WinUSBDrive(index);
                    break;
                default:
                    throw new Exception("Unsupported drive type: " + type);
            }
            return drive;
        }

        public IOPort createIOPort(int address)
        {
            return new WinIOPort(address);
        }

        public Monitor createMonitor(int id)
        {
            return new WinMonitor(id);
        }

        public Process createProcess(int id)
        {
            return new WinProcess(id);
        }
    }
}