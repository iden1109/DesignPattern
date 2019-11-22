using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.State.Exercise
{
    class DownHard : IState
    {
        public void check(Host host, CheckResult result)
        {
            switch (result)
            {
                case CheckResult.UP:
                    
                      
                            host.changeState(Host.UP_SOFT);
                            break;
                        
                   
                case CheckResult.DOWN:

                    host.increateAttempt();
                            break;
                        
            }
        }

        public String diagnostic(Host host)
        {

                    return host.outOfBandDiagnostic();
              
        }

        public void powerOff(Host host)
        {
        
                    Console.WriteLine("Cannot power off under down hard state.");
           
        }

        public void powerOn(Host host)
        {

                    host.doPowerOn();

        }
    }
}
