using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismTask 
{
    internal class DrukDokumentu : ZlecenieDruku
    {
        public DrukDokumentu (string number, int page) : base(number, page)
        {

        }
        public override int ObliczCzasRealizacji()
        {
            return (int)Math.Ceiling(Page / 20.0);
        }

        
    }
}
