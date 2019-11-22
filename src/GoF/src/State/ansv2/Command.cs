/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Ansv2
{
    public interface Command
	{
        CheckResult execute();
    }
}
