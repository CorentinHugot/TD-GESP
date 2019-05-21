using System.Collections.Generic;
using System.Linq;

namespace PubLinkLib
{
    // Représente une collection de liens web
    public class Collection
    {
        private List<Lien> _listeLiens;

        public Collection()
        {
            _listeLiens = new List<Lien>();
        }

        ///<summary> Compte le nombre de liens dans la liste </summary>
        public int Compte
        {
            get { return _listeLiens.Count; }
        }

        public Lien Get(int indice)
        {
            return _listeLiens.ElementAt(indice);
        }

        ///<summary>  Ajoute un lien dans la liste </summary>
        public void Ajouter(Lien unLien)
        {
            _listeLiens.Add(unLien);
        }

        public void Enlever(int indice)
        {
            _listeLiens.RemoveAt(indice);
        }
    }
}
