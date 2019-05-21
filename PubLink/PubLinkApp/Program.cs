using System;
using PubLinkLib;

namespace PubLinkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection listeLiens = new Collection(); ;
            listeLiens.Ajouter(new Lien("Hacker News", "https://news.ycombinator.com"));
            listeLiens.Ajouter(new Lien("Reddit", "https://reddit.com"));
            listeLiens.Ajouter(new Lien("Boing Boing", "boingboing.net"));

            string choix = "";
            while (choix != "3")
            {
                string choixPossibles = "\n0 : Lister les liens";
                choixPossibles += "\n1 : Ajouter un lien";
                choixPossibles += "\n2 : Enlever un lien";
                choixPossibles += "\n3 : Quitter";
                Console.WriteLine("Choisissez une action : " + choixPossibles);
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "0":
                        if (listeLiens.Compte > 0)
                        {
                            for (int i = 0; i < listeLiens.Compte; i++)
                            {
                                Console.WriteLine((i+1) + " : " + listeLiens.Get(i));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Aucun lien à afficher !");
                        }
                        break;
                    case "1":
                        Console.WriteLine("Titre du lien : ");
                        string titre = Console.ReadLine();
                        Console.WriteLine("Url du lien : ");
                        string url = Console.ReadLine();
                        listeLiens.Ajouter(new Lien(titre, url));
                        break;
                    case "2":
                        Console.WriteLine("Quel lien supprimer (numéro) ? ");
                        listeLiens.Enlever(int.Parse(Console.ReadLine())-1);
                        break;

                }
                Console.WriteLine();
            }
            Console.WriteLine("Au revoir !");

            Console.ReadKey();
        }
    }
}
