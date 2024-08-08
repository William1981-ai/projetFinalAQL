using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinalAQL
{    // FAIS PAR WILLIAM 
    internal class Program
    {
        static void Main(string[] args)
        {

            //creation des etudiants 
            List<Etudiant> etudiantList = new List<Etudiant>();
            Console.WriteLine($"Entrer le numero etudiant ");
            string numeroEtudiant= Console.ReadLine();
            Console.WriteLine($"Entrer le nom: ");
            string nomEtudiant;
            nomEtudiant = Console.ReadLine();
            Console.WriteLine($"Entrer le prenom");
            string prenomEtudiant;
            prenomEtudiant= Console.ReadLine();

            Etudiant nouveauEtudiant=new Etudiant(numeroEtudiant, nomEtudiant, prenomEtudiant);
            etudiantList.Add(nouveauEtudiant);
            Console.WriteLine("Étudiant ajouté.");

            // Ceation des cours 
            List<Cours> cours = new List<Cours>();
            Console.WriteLine($"veuillez entrer le numero de cours");
            int numerocours = int.Parse(Console.ReadLine());
            Console.WriteLine($"Entrer le titre du cours");
            string titreCours = Console.ReadLine();
            Console.WriteLine($"entrer le code du cours");
            string codeCours = Console.ReadLine();

            Cours nouveauCours = new Cours (numerocours, titreCours, codeCours);
            cours.Add(nouveauCours);
            Console.WriteLine("Cours ajouté.");


            //creation des notes
            List<Notes> notesfinales = new List<Notes>();
            Console.WriteLine("Entrer le numero etudiant");
            Console.ReadLine();
            Console.WriteLine($"Entrer le numero de cours");
            numerocours = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer la note ");
            int note = int.Parse(Console.ReadLine());

            Notes nouvellenote = new Notes(numeroEtudiant, numerocours, note);
            notesfinales.Add(nouvellenote);
            Gestion.EnregistrerNotes(new List<Notes> { nouvellenote });
            Console.WriteLine("Note enregistrée.");



            Console.Write("Numéro d'étudiant: ");
               
            List<string> noteList = Gestion.LectureNotes(numeroEtudiant);
            Console.ReadLine();
            if (noteList.Count > 0)
             {
                 Console.WriteLine($"Notes pour l'étudiant {numeroEtudiant}:");
                 foreach (string n in noteList)
                 {
                    Console.WriteLine(n);
                 }
            }
            else 
            {
                Console.WriteLine("Aucune note trouvée pour cet étudiant.");
            }
                

            
               
                
            


        }
    }
}
