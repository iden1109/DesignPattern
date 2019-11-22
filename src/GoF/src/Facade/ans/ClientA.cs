/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Facade.Ans
{
    public class ClientA
    {
		MultiFunctionPrinter mfp;

		public ClientA(MultiFunctionPrinter mfp)
		{
			this.mfp = mfp;
		}

		public void copy(int copies) {
	        for(int i = 0; i<copies; i++){
	            mfp.copy();
	        }
        }

	    public int getNumberOfPapers()
	    {
		    return mfp.getNumberOfPapers();
	    }
    }
}
