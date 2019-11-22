/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ansv2
{
    public class UpHard : State
    {
        public void powerOff(Host host)
        {
            host.doGracefulPowerOff();
        }
        public void powerOn(Host host)
        {
            Console.WriteLine("Cannot power on under up hard state.");
        }
        public String diagnostic(Host host)
        {
            return host.inBandDiagnostic();
        }
        public void up(Host host)
        {
            host.incAttempt();
        }
        public void down(Host host)
        {
            host.changeState(Host.DOWN_SOFT);
        }
    }
}
