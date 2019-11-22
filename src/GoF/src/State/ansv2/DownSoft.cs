/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ansv2
{
    public class DownSoft : State
    {
        public void powerOff(Host host)
        {
            Console.WriteLine("Cannot power off under down soft state.");
        }

        public void powerOn(Host host)
        {
            Console.WriteLine("Cannot power on under down soft state.");
        }

        public String diagnostic(Host host)
        {
            return host.outOfBandDiagnostic();
        }
        public void up(Host host)
        {
            host.changeState(Host.UP_HARD);
        }
        public void down(Host host)
        {
            host.incAttempt();
            if (host.getAttempt() >= host.getMaxAttempt())
                host.changeState(Host.DOWN_HARD);
        }
    }
}
