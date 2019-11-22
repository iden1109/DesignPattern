﻿/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Facade.Ans
{
    public class Scanner
	{
        public virtual void warmup()
		{
			// prepare the scanner to scan documents and
			// throws ScannerException when encountering errors
		}

		public virtual Image start()
		{
			// scan the document into an image
			return new Image();
		}
	}
}
