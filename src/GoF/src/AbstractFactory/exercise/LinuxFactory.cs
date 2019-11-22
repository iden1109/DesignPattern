/*
 * Copyright 2017 TeddySoft Technology.
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.AbstractFactory.Exercise
{
    class LinuxFactory : IFactory
    {
        public LinuxFactory()
        {
        }

        public Drive createDrive(string type, int index)
        {
            Drive drive = null;
            switch (type)
            {
                case "SATA":
                    drive = new LinuxSATADrive(index);
                    break;
                case "USB":
                    drive = new LinuxUSBDrive(index);
                    break;
                default:
                    throw new Exception("Unsupported drive type: " + type);
            }
            return drive;
        }

        public IOPort createIOPort(int address)
        {
            return new LinuxIOPort(address);
        }

        public Monitor createMonitor(int id)
        {
            return new LinuxMonitor(id);
        }

        public Process createProcess(int id)
        {
            return new LinuxProcess(id);
        }
    }
}