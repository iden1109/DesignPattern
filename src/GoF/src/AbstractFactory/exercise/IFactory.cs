using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.AbstractFactory.Exercise
{
    public interface IFactory
    {
        Drive createDrive(string type, int index);
        IOPort createIOPort(int address);
        Process createProcess(int id);
        Monitor createMonitor(int id);
    }
}
