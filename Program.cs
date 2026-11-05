
using System;
using System.Collections.Generic;

class FKTrouverNombreCache
{
    static Random hasard = new Random();
    static double meilleureNote = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            AfficherMessage("=== JEU DU NOMBRE CACHE ===");
            AfficherMessage("Choisissez 'F' - Facile, 'D' - Difficile, 'Q' - Quitter");

            string choix = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (choix == "Q")
            {
                Console.Clear();
                AfficherMessage("Au revoir !");
                AfficherMessage($"Meilleure note : {meilleureNote:F2}%");
                break;
            }
            else if (choix == "F")
            {
                JouerFacile();
            }
            else if (choix == "D")
            {
                JouerDifficile();
            }
            else
            {
                AfficherMessage("Choix 'F', 'D' ou 'Q'");
            }
        }
    }

    // Méthode demandée dans le TP pour afficher les messages
    static void AfficherMessage(string message)
    {
        Console.WriteLine(message);
    }

    // ==============================
    // MODE FACILE
    // ==============================

    static void JouerFacile()
    {
        int min = 1;
        int max = 10;

        while (true)
        {
            int nombreCache = hasard.Next(min, max + 1);
            int essais = 0;

            List<int> reponses = new List<int>();

            while (true)
            {
                AfficherMessage("Choisissez un nombre entre [1, 10] ou 'Q' - Quitter");

                string saisie = (Console.ReadLine() ?? "").Trim();

                if (saisie.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    AfficherMessage($"Meilleure note : {meilleureNote:F2}%");
                    return;
                }

                if (!int.TryParse(saisie, out int choix))
                {
                    AfficherMessage("Veuillez entrer un nombre entier valide.");
                    continue;
                }

                if (choix < min || choix > max)
                {
                    AfficherMessage("Réponse doit être comprise entre 1 et 10.");
                    continue;
                }

                essais++;
                reponses.Add(choix);

                if (choix == nombreCache)
                {
                    AfficherMessage("Vous avez gagné !");

                    CalculerNote(min, max, essais);

                    AfficherMessage("Appuyez sur Entrée pour continuer.");
                    Console.ReadLine();

                    Console.Clear();
                    break;
                }
                else
                {
                    AfficherMessage("Vous avez perdu !");

                    AfficherMessage("Réponses déjà données : " +
                        string.Join(", ", reponses));
                }
            }
        }
    }

    // ==============================
    // MODE DIFFICILE
    // ==============================

    static void JouerDifficile()
    {
        while (true)
        {
            AfficherMessage("Entrez les bornes min et max de l'intervalle (ou Q pour quitter).");
            AfficherMessage("Exemple : 1 20");

            string saisie = (Console.ReadLine() ?? "").Trim();

            if (saisie.Equals("Q", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                return;
            }

            string[] bornes = saisie.Split(
                new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            if (bornes.Length != 2 ||
                !int.TryParse(bornes[0], out int min) ||
                !int.TryParse(bornes[1], out int max) ||
                min >= max ||
                (long)max - min <= 10)
            {
                AfficherMessage(
                    "Choisissez 2 nombres entiers et (max - min) doit être > à 10."
                );
                continue;
            }

            int nombreCache = hasard.Next(min, max + 1);
            int essais = 0;

            while (true)
            {
                AfficherMessage(
                    $"Choisissez un nombre entre [{min}, {max}] ou 'Q' - Quitter"
                );

                string reponse = (Console.ReadLine() ?? "").Trim();

                if (reponse.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    break;
                }

                if (!int.TryParse(reponse, out int choix))
                {
                    AfficherMessage("Veuillez entrer un nombre entier valide.");
                    continue;
                }

                if (choix < min || choix > max)
                {
                    AfficherMessage(
                        $"Choix doit être compris entre {min} et {max}."
                    );
                    continue;
                }

                essais++;

                if (choix == nombreCache)
                {
                    AfficherMessage("Vous avez gagné !");

                    CalculerNote(min, max, essais);

                    AfficherMessage("Appuyez sur Entrée pour continuer.");
                    Console.ReadLine();

                    Console.Clear();
                    break;
                }
                else
                {
                    AfficherMessage("Vous avez perdu !");
                }
            }
        }
    }

    // ==============================
    // CALCUL DE LA NOTE
    // ==============================

    static void CalculerNote(int min, int max, int essais)
    {
        double etendue = (long)max - min + 1;

        double note = ((etendue - essais) / etendue) * 100;

        AfficherMessage($"Nombre d'essais : {essais}");
        AfficherMessage($"Votre note : {note:F2}%");

        if (note > meilleureNote)
        {
            meilleureNote = note;
            AfficherMessage("Nouvelle meilleure note !");
        }
    }
}
