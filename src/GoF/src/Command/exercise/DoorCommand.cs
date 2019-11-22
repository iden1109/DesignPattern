using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Teddysoft.Gof.Command.Exercise;

namespace TW.Teddysoft.src.Command.exercise
{
    class DoorCommand : ICommand
    {
        private Door _door;

        public DoorCommand(Door door)
        {
            this._door = door;
        }

        public Result execute()
        {
            Result result = new Result(Status.PENDING);

            if ("open".Equals(this._door.getDoorStatus()))
            {
                result.setStatus(Status.CRITICAL);
                result.setMessage("門被打開");
            }
            else
            {
                result.setStatus(Status.OK);
            }
            return result;
        }
    }
}
