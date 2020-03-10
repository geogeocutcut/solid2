using System;
using System.Collections.Generic;
using System.Text;

namespace solid.example._03___Liskov_substitution.bad
{
    public class OiseauElectrique:Oiseau
    {
        public bool On = false;

        public override void Vole()
        {
            if(On)
              base.Vole();
        }

        public void Allumer()
        {
            On = true;
        }

        public void Eteindre()
        {
            On = false;
        }
    }
}
