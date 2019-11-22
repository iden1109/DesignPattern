/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ansv2
{
    public interface State
    {
        void powerOff(Host host);
        void powerOn(Host host);
        String diagnostic(Host host);
        void up(Host host);
        void down(Host host);
    }
}
