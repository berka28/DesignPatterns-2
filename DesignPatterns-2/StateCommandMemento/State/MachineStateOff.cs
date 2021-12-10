using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_2.StateCommandMemento.State
{
    public class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning on.....\n");
        }
    }
}
