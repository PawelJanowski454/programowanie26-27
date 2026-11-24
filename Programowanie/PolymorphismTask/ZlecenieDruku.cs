using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;

namespace PolymorphismTask
{
    internal abstract class ZlecenieDruku   
    {

        

        public string? Number { get; set; }
        public int Page { get; set; }
        private decimal price = 1;
        public decimal Price 
        {
            get { return price; }
            set { price = value; }
        }

  

        public ZlecenieDruku(string number, int page)
        {
            Number = number;
            Page = page;
        }

        public virtual decimal ObliczKoszt()
        {
            return Page * Price;
        }
        public abstract int ObliczCzasRealizacji();

       




    }
}
