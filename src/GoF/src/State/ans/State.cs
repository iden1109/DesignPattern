/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ans
{
    public interface State
    {
        void powerOff(Host host);
        void powerOn(Host host);
        String diagnostic(Host host);
        void check(Host host, CheckResult result);
    }
}
