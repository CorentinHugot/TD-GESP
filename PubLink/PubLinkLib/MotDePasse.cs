using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubLinkLib
{
    public class MotDePasse
    {
        public string _mot { get; set; }

        public MotDePasse (string mot)
        {
            Random rdn = new Random();
            while (!Verifier(mot))
                mot = Completer(rdn, mot);
            _mot = mot;
        }
        
        public bool Verifier(string mot)
        {
            return (mot.Length >= 8 && ContientChiffre(mot));
        }

        /*public bool ContientChiffre(string mot)
        {
            for (int i = 0; i < mot.Length; i++)
                foreach (int j in new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })
                    if (i == j)
                        return true;
            return false;
        }*/

        public bool ContientChiffre(string mot)
        {
            for (int i = 0; i < mot.Length; i++)            
                if (Char.IsDigit(mot[i]))
                    return true;
                return false;            
        }

        public string Completer (Random rdn, string mot)
        {
            return mot + rdn.Next(0, 10);
        }


    }
}
