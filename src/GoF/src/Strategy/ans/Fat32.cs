/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Strategy.Ans
{
    public class Fat32 : Formater
    {
        public void execute()
        {
            Console.WriteLine("格式化為FAT32");
        }
    }
}
