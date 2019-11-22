using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.State.Exercise
{
    class UPSoft : IState
    {
        public void check(Host host, CheckResult result)
        {
            switch (result)
            {
                case CheckResult.UP:

                    host.increateAttempt();
                            if (host.getAttempt() >= host.getMaxAttempt())
                                host.changeState(Host.UP_HARD);
                            break;
                        
                case CheckResult.DOWN:
                    
                            host.changeState(Host.DOWN_HARD);
                            break;
                        
            }
        }

        public String diagnostic(Host host)
        {
           
                    String result = host.inBandDiagnostic();
            if ("" == result)
                return host.outOfBandDiagnostic();
            else
                return result;
               
        }

        public void powerOff(Host host)
        {
           
             host.doPowerOff(60);
            
        }

        public void powerOn(Host host)
        {

                    Console.WriteLine("Cannot power on under up soft state.");
          
        }
    }
}
