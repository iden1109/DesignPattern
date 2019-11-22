/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Observer.Ans
{
    public class Result
	{
        private Status status;
		private String msg = "";

        public Result(Status status)
        {
            this.status = status;
        }

        public Status getStatus()
		{
			return status;
		}

		public String getMessage()
		{
			return msg;
		}

		public void setStatus(Status statusCode)
		{
			status = statusCode;
		}

		public void setMessage(String msg)
		{
			this.msg = msg;
		}
    }
}
