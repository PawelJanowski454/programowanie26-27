using System;

namespace PrinterTaskConsoleApp
{
    internal class Printer
    {

        private string name;
        private int paperCount;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PaperCount
        {
            get { return paperCount; }
            set { if (value >= 0) 
                    paperCount = value; 
            }
        }

        public void Show()
        {
            Console.WriteLine("Info o obiekcie");
            Console.WriteLine(paperCount);
            Console.WriteLine(name);
        }

        public Printer(string prname, int value)
        {
            name = prname;
            PaperCount = value;
        }

        public void Check(int value)
        {
            if (value >= 0)
            {
                paperCount = value;
            }
        }

        public bool Print(int pageCount)
        {
            if (pageCount > 0 && pageCount <= paperCount) {
                paperCount -= pageCount;
                return true;
            }
            return false;
        }


    }
}


