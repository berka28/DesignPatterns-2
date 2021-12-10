using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts           

            IPrintingIntsService printingIntsService = new PrintingIntsService();

            printingIntsService.Print();
        }
    }
}
