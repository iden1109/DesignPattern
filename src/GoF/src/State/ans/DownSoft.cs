/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ans
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

        public void check(Host host, CheckResult result)
        {
            if (CheckResult.UP == result)
            {
                host.changeState(Host.UP_HARD);
            }
            else if (CheckResult.DOWN == result)
            {
                host.incAttempt();
                if (host.getAttempt() >= host.getMaxAttempt())
                {
                    host.changeState(Host.DOWN_HARD);
                }
            }
        }
    }
}
