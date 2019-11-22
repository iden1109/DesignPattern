/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;
using System.Text;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public class WindowCommand : Command
	{
    	private Window window = null;

		public WindowCommand(String ipAddress)
		{
			window = new Window(ipAddress);
		}
		public Result execute()
		{
			Result result = new Result(Status.OK);
			StringBuilder sb = new StringBuilder();

			if (window.isBroken())
			{
				result.setStatus(Status.CRITICAL);
				sb.Append("窗戶被打破");
			}
			if (window.isOpen())
			{
				result.setStatus(Status.CRITICAL);
                if (sb.Length > 0)
                    sb.Append(", ");
                sb.Append("窗戶被打開");
			}
        	result.setMessage(sb.ToString());
			return result;
		}
    }
}
