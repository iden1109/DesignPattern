using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.Teddysoft.src.Observer.exercise
{
    public interface IObserver
    {
        void update(ISubject subject);
    }
}
