using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.State.Exercise
{
    class UPHard : IState
    {
        public void check(Host host, CheckResult result)
        {
            switch (result)
            {
                case CheckResult.UP:

                    host.increateAttempt();
                            break;
                        
                case CheckResult.DOWN:
                    
                            host.changeState(Host.DOWN_SOFT);
                            break;
                      
            }
        }

        public String diagnostic(Host host)
        {
      
                    return host.inBandDiagnostic();
                
        }

        public void powerOff(Host host)
        {

             host.doGracefulPowerOff();
           
        }

        public void powerOn(Host host)
        {

                    Console.WriteLine("Cannot power on under up hard state.");
            
        }
    }
}
