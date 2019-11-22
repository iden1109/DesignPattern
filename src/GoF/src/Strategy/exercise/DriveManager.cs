/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Strategy.Exercise
{
    public class DriveManager
    {
        public void format(IFormater formater)
        {
            if (formater != null)
                formater.execute();
        }
    }
}
