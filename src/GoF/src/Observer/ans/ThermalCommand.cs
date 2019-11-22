/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public class ThermalCommand : Command
	{
	    private Thermal thermal = null;

		public ThermalCommand(String ipAddress)
		{
			thermal = new Thermal(ipAddress);
		}
	
    	public Result execute()
	    {
			Result result = new Result(Status.OK);
			if (thermal.isOverheat())
			{
				result.setStatus(Status.CRITICAL);
				result.setMessage("溫度過熱");
			}
			return result;
		}
    }
}
