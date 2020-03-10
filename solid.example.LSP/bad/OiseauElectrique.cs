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
            Allumer();
            base.Vole();
            // Log
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
