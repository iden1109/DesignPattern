using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Teddysoft.Gof.Command.Exercise;

namespace TW.Teddysoft.src.Command.exercise
{
    class ThermalCommand : ICommand
    {
        private Thermal _thermal;

        public ThermalCommand(Thermal thermal)
        {
            this._thermal = thermal;
        }

        public Result execute()
        {
            Result result = new Result(Status.PENDING);

            if (this._thermal.isOverheat())
            {
                result.setStatus(Status.CRITICAL);
                result.setMessage("溫度過熱");
            }
            return result;
        }
    }
}
