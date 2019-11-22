/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Facade.Ans
{
    public class ClientB
    {
		MultiFunctionPrinter mfp;

		public ClientB(MultiFunctionPrinter mfp)
		{
			this.mfp = mfp;
		}

		public String copy()
		{
			if (mfp.copy())
				return "";
			else
				return mfp.getLCDMessage();
		}
    }
}
