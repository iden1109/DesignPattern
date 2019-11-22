/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ansv2
{
    public class UpSoft : State
    {
        public void powerOff(Host host)
        {
            host.doPowerOff(60);
        }
        public void powerOn(Host host)
        {
            Console.WriteLine("Cannot power on under up soft state.");
        }
        public String diagnostic(Host host)
        {
            String result = host.inBandDiagnostic();
            if ("" == result)
                return host.outOfBandDiagnostic();
            else
                return result;
        }
        public void up(Host host)
        {
            host.incAttempt();
            if (host.getAttempt() >= host.getMaxAttempt())
                host.changeState(Host.UP_HARD);
        }
        public void down(Host host)
        {
            host.changeState(Host.DOWN_HARD);
        }
    }
}
