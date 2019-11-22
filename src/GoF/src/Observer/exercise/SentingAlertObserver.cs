using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tw.Teddysoft.Gof.Observer.Exercise;

namespace TW.Teddysoft.src.Observer.exercise
{
    class SentingAlertObserver : IObserver
    {
        public void update(ISubject subject)
        {
            Client client = (Client)subject;
            if (Status.OK != client.getResult().getStatus())
                sendAlert(client.getResult().getMessage());
        }

        public void sendAlert(String msg)
        {
            Console.WriteLine("發現問題並通知保全人員: " + msg);
        }
    }
}
