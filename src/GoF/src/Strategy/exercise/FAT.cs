using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tw.Teddysoft.Gof.Strategy.Exercise
{
    class FAT : IFormater
    {
        public void execute()
        {
            Console.WriteLine("格式化為FAT");
        }
    }
}
