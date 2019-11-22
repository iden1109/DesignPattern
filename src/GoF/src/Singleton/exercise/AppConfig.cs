using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.Singleton.Exercise
{
    class AppConfig
    {
        private class Lazy
        {
            static Lazy() { }
            internal static readonly AppConfig instance = new AppConfig();
        }

        
        private AppConfig() { }

        public static  AppConfig getInstance()
        {
            return Lazy.instance;
        }



    }
}
