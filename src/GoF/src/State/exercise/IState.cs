using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.State.Exercise
{
    public interface IState
    {
        void check(Host host, CheckResult result);
        void powerOff(Host host);
        void powerOn(Host host);
        String diagnostic(Host host);
    }
}
