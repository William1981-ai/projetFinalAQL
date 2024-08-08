using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinalAQL
{
    internal class Gestion
    {
        public static void EnregistrerNotes(List<Notes> notesList)
        {
            foreach (var nbrepoints in notesList)
            {
                string dossierEtudiant = $"etudiant_{nbrepoints.NumeroEtudiant}.txt";
                // implementation et utilisation de l'objet Streamwritter qui nous permettra
                // d'ecrire des caractere dans le fichier ou dossier etudiant
                using (StreamWriter dossier = new StreamWriter(dossierEtudiant, append: true))
                {
                    dossier.WriteLine($"{nbrepoints.NumerosCours}: {nbrepoints.Note}");
                }
            }
        }
        //creation de notre methode LectureNotes qui lira le contenu du fichier et nous enverra
        //le resultat sous forme de liste de chaines
        public static List<string> LectureNotes(string numeroEtudiant)
        {
            string dossierEtudiant = $"etudiant_{numeroEtudiant}.txt";
            //creation de la lste des notes
            List<string> nbrepoints = new List<string>();
            if (File.Exists(dossierEtudiant))
            {
                //implementation d el'objet StreamerReader qui nous permettra d'ouvrir et lire le contenu du fichier 
                using (StreamReader file = new StreamReader(dossierEtudiant))
                {
                    string ligne;
                    while ((ligne = file.ReadLine()) != null)
                    {
                        nbrepoints.Add(ligne);
                    }
                }
            }
            return nbrepoints;
        }
    }
}
