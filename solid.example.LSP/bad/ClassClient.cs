using System;
using System.Collections.Generic;
using System.Text;

namespace solid.example._03___Liskov_substitution.bad
{
    public class ClassClient
    {
        public void VoleTous(List<Oiseau> oiseaux)
        {
            int nbOiseauEnVol = 0;
            foreach (Oiseau oiseau in oiseaux)
            {
                oiseau.Vole();
                if (oiseau.Etat == EtatOiseau.EnVol)
                    nbOiseauEnVol++;
            }
            if (nbOiseauEnVol != oiseaux.Count)
            {
                throw new Exception("Erreur : Certains oiseaux ne vole pas !!!");
            }
        }

        public void VoleTousBis(List<Oiseau> oiseaux)
        {
            int nbOiseauEnVol = 0;
            foreach (Oiseau oiseau in oiseaux)
            {
                if(oiseau is OiseauElectrique)
                {
                    ((OiseauElectrique)oiseau).Allumer();
                }
                oiseau.Vole();
                if (oiseau.Etat == EtatOiseau.EnVol)
                    nbOiseauEnVol++;
            }
            if (nbOiseauEnVol != oiseaux.Count)
            {
                throw new Exception("Erreur : Certains oiseaux ne vole pas !!!");
            }
        }

    }
}
