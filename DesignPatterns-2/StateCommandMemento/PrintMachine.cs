using DesignPatterns_2.StateCommandMemento.Command;
using DesignPatterns_2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_2.StateCommandMemento
{
    public class PrintMachine : IMachineState, IMachine
    {
        public IMachineState MachineState { get; set; }
        public List<MachineCommand> WordList { get; set; }

        public PrintMachine()
        {
            MachineState = new MachineStateOff();
            WordList = new List<MachineCommand>();
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
            }
            else
            {
                MachineState = new MachineStateOff();
            }
        }

        public void Print(string word)
        {
            Console.WriteLine("\nPrinting...");
            Console.WriteLine($"{word}");
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, WordList);
        }
    }
}
