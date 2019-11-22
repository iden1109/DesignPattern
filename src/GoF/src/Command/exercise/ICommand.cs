using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Teddysoft.Gof.Command.Exercise;

namespace TW.Teddysoft.src.Command.exercise
{
    public interface ICommand
    {
        Result execute();

    }
}
