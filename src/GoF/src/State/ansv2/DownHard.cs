/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ansv2
{
    public class DownHard : State
    {
        public void powerOff(Host host)
        {
            Console.WriteLine("Cannot power off under down hard state.");
        }

        public void powerOn(Host host)
        {
            host.doPowerOn();
        }

        public String diagnostic(Host host)
        {
            return host.outOfBandDiagnostic();
        }

        public void up(Host host)
        {
            host.changeState(Host.UP_SOFT);
        }
        public void down(Host host)
        {
            host.incAttempt();
        }
    }
}
