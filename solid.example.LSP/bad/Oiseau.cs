using System;
using System.Collections.Generic;
using System.Text;

namespace solid.example._03___Liskov_substitution.bad
{
    public enum EtatOiseau { EnVol, Nage, AuRepos };
    public class Oiseau
    {
        public EtatOiseau Etat = EtatOiseau.AuRepos;

        public virtual void Vole()
        {
            Etat = EtatOiseau.EnVol;
        }

    }
}
