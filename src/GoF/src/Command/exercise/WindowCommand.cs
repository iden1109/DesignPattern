using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Teddysoft.Gof.Command.Exercise;

namespace TW.Teddysoft.src.Command.exercise
{
    class WindowCommand : ICommand
    {
        private Window _window;

        public WindowCommand(Window window)
        {
            this._window = window;
        }

        public Result execute()
        {
            Result result = new Result(Status.PENDING);
            if (this._window.isOpen())
            {
                result.setStatus(Status.CRITICAL);
                result.setMessage("窗戶被開啟");
            }
            if (this._window.isBroken())
            {
                result.setStatus(Status.CRITICAL);
                result.setMessage("窗戶被打破");
            }
            return result;
        }
    }
}
