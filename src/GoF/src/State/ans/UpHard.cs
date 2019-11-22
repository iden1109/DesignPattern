/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ans
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
        public void check(Host host, CheckResult result)
        {
            if (CheckResult.UP == result)
            {
                host.incAttempt();
            }
            else if (CheckResult.DOWN == result)
            {
                host.changeState(Host.DOWN_SOFT);
            }
        }
    }
}
