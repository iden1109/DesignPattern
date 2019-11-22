/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ans
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

        public void check(Host host, CheckResult result)
        {
            if (CheckResult.UP == result)
            {
                host.changeState(Host.UP_SOFT);
            }
            else if (CheckResult.DOWN == result)
            {
                host.incAttempt();
            }
        }
    }
}
