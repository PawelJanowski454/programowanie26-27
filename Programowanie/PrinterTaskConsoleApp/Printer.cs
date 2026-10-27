using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterTaskConsoleApp
{
    internal class Printer
    {
        int Name { get; set; }

        private int PaperCount;

        int PAPERCOUNT { get; set; }


    public void Show()
        {
            Console.WriteLine("Info o obiekcie");
            Console.WriteLine(PAPERCOUNT);
        }
    }
}
