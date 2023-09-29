using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHNELZAUER_Lucas_TD2_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration du tableau contenant les mois de l'année
            string[] tableauAnnée = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai","Juin","Juillet","Août","Septembre","Octobre","Novembre","Décembre" };
            
            
            //Changer la couleur du texte en vert
            Console.ForegroundColor = ConsoleColor.Green;
           
            //Afficher les choix à l'utilisateur 
            Console.WriteLine("Veuillez sélectionner votre choix : ");
            Console.WriteLine("(1) Lister les noms des 12 mois");
            Console.WriteLine("(2) Lister les mois en rouge contenant la lettre ‘r’");
            Console.WriteLine("(3) Lister les 12 mois avec : Le N° du mois et son nom");

            //Attribution de la valeur de l'utilisateur à la variable choix de type chaine
            string choix = Console.ReadLine();
            //Convertir la chaine en entier
            Int32 choixchiffre = Convert.ToInt32(choix);

            if(choixchiffre == 1)
            {
                Console.WriteLine("Voici les 12 mois de l'année :");
                for (int i = 0; i < tableauAnnée.Length; i++)
                {
                    Console.WriteLine(tableauAnnée[i]);
                }
            }
            else if(choixchiffre == 2)
            {
                Console.WriteLine("Voici les 12 mois avec les mois en rouge contenant la lettre 'r' :");

                for (int i = 0; i < tableauAnnée.Length; i++)
                {
                    // Vérifie si le mois contient la lettre 'r'.
                    if (tableauAnnée[i].Contains("r"))
                    {
                        // Afficher le texte en rouge pour les mois  contenant  la lettre "r"
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        // Afficher le texte en vert pour les mois ne contenant pas la lettre "r"
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    // Afficher le mois
                    Console.WriteLine(tableauAnnée[i]);
                }
            }
            else if(choixchiffre == 3)
            {
                Console.WriteLine("Voici les 12 mois de l'année avec les chiffres :");
                
                for (int i = 0; i < tableauAnnée.Length; i++)
                {
                   
                    Console.WriteLine(i+1+" "+tableauAnnée[i]);
                }
            }
            else
            {
                Console.WriteLine("Erreur vous n'avez pas saisi l'un des choix qui vous est proposé");
            }
            Console.ReadLine();
        }
    }
}
