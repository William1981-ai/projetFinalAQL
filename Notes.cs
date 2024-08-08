using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinalAQL
{    //FAIS PAR WILLIAM
    //Creation de la classe notes
    internal class Notes
    {
        //Definition des variables
        private string numeroEtudiant;
        private int numerosCours;
        private decimal note;

        //elaboration des constructeurs
        public Notes(string numeroEtudiant, int numerosCours, decimal note)
        {
            this.numeroEtudiant = numeroEtudiant;
            this.numerosCours = numerosCours;
            this.note = note;
        }
        // elaboration de get et set
        public string NumeroEtudiant
        { 
            get => numeroEtudiant;
            set => numeroEtudiant = value;
        }
        public int NumerosCours
        { 
            get => numerosCours; 
            set => numerosCours = value; 
        }
        public decimal Note
        {
            get => note;
            set => note = value; }

        //implementation de la methode ToString pour l'affichage
        public override string ToString()
        {
            return $"Etudiant {NumeroEtudiant}, Cours {NumerosCours}: Note {Note}"; 
        }
    }
}
