using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Communications.Tcp
{
    public interface IListener
    {
        void listen();
        void stop();
    }
}
