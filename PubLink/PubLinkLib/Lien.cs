namespace PubLinkLib
{
    // Représente un lien web
    public class Lien
    {
        public string _titre { get; private set; }
        public string _url { get; private set; }

        public Lien(string unTitre, string unUrl)
        {
            _titre = unTitre;
            if (unUrl.Substring(0,4) != "http")
                _url = "http://www." + unUrl;
            else
                _url = unUrl;
        }

        ///<summary>  Ecrit le titre et l'url du site </summary>
        public override string ToString()
        {
            return _titre + " " + _url;
        }
    }
}
