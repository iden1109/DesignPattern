/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ans
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
        public void check(Host host, CheckResult result)
        {
            if (CheckResult.UP == result)
            {
                host.incAttempt();
                if (host.getAttempt() >= host.getMaxAttempt())
                    host.changeState(Host.UP_HARD);
            }
            else if (CheckResult.DOWN == result)
            {
                host.changeState(Host.DOWN_HARD);
            }
        }
    }
}
