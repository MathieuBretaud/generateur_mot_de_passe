using System;

namespace generateur_mot_de_passe
{
    class Program
    {
        static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }
        static int DemanderNombreEntre(string question, int min, int max)
        {
            
             int nombre = DemanderNombre(question);
             if ((nombre >= min) && (nombre <= max))
             {
                return nombre;
             }
             Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);

           return DemanderNombreEntre(question, min, max);
            

        }

        static int DemanderNombre(string question)
        {
           
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    Console.WriteLine("OK");
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
            
            
        }

        static void Main(string[] args)
        {
            int longueurMotDePasse = DemanderNombre("Longueur du mot de passe : ");
        }
    }
}