using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinalAQL
{ /// FAIS PAR MALICK
  /// creation de la classe Etudiant 

    internal class Etudiant
    {
        //definition des variables
        private string numeroEtudiant;
        private string nom;
        private string prenom;

        //Elaboration des constructeurs 
        public Etudiant(string numeroEtudiant, string nom, string prenom)
        {
            this.numeroEtudiant = numeroEtudiant;
            this.nom = nom;
            this.prenom = prenom;
        }
        // definition des getteurs et setteurs
        public string NumeroEtudiant
        {
            get => numeroEtudiant;
            set => numeroEtudiant = value;
        }
        public string Nom
        {
            get => nom;
            set => nom = value;
        }
        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }

        //implementation de la methode ToString pour l'affichage
        public override string ToString()
        {
            return $"Information sur les etudiants : {this.NumeroEtudiant} {this.Nom} {this.Prenom}";
        }
    }

}
 