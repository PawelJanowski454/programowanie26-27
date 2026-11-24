using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismTask
{
    internal class DrukPlakatu : ZlecenieDruku
    {
        public DrukPlakatu(string number, int page) : base(number, page)
        {

        }
        public override decimal ObliczKoszt()
        {
            return base.ObliczKoszt() + 12;
        }
        public override int ObliczCzasRealizacji()
        {
            return 5 + Page * 3;
        }
    }
}
