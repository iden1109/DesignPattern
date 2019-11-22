/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.State.Exercise
{
    public interface Command
	{
        CheckResult execute();
    }
}
