using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.State.Exercise
{
    class DownSoft : IState
    {
        public void check(Host host, CheckResult result)
        {
            switch (result)
            {
                case CheckResult.UP:
                    host.changeState(Host.UP_HARD);
                    break;  
                case CheckResult.DOWN:
                    host.increateAttempt();
                    if (host.getAttempt() >= host.getMaxAttempt())
                    {
                        host.changeState(Host.DOWN_HARD);
                    }
                    break;  
            }
        }

        public String diagnostic(Host host)
        {

                    return host.outOfBandDiagnostic();
        }

        public void powerOff(Host host)
        {

                    Console.WriteLine("Cannot power off under down soft state.");

        }

        public void powerOn(Host host)
        {

                    Console.WriteLine("Cannot power on under down soft state.");

        }
    }
}
