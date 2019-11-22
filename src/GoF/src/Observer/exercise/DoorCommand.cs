/*
 * Copyright 2017 TeddySoft Technology. 
 * 
 */
using System;

namespace Tw.Teddysoft.Gof.Observer.Exercise
{
    public class DoorCommand : Command
	{
		private Door door = null;

		public DoorCommand(String ipAddress)
		{
			door = new Door(ipAddress);
		}

		public DoorCommand(Door door)
		{
			this.door = door;
		}

		public Result execute()
		{
			Result result = new Result(Status.OK);

			if ("open".Equals(door.getDoorStatus()))
			{
				result.setStatus(Status.CRITICAL);
				result.setMessage("門被開啟");
			}
			return result;
		}
    }
}
