using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinalAQL
{ //Creation de la classe Cours 
    internal class Cours
    {
        //Definition des variables
        private int numeroCours;
        private string titre;
        private string code;

        //Generation du constructeurs 
        public Cours(int numeroCours, string titre, string code)
        {
            this.numeroCours = numeroCours;
            this.titre = titre;
            this.code = code;
        }
        //Generation des get et set
        public int NumeroCours 
        {
            get => numeroCours; 
            set => numeroCours = value; 
        }
        public string Titre 
        {
            get => titre; 
            set => titre = value; 
        }
        public string Code 
        {
            get => code; 
            set => code = value; 
        }

        //implementation de la methode ToString pour l'affichage
        public override string ToString()
        {
            Console.WriteLine("Information sur le cours ");
            return $": {this.NumeroCours} - {this.Code}: {this.Titre}";
        }
    }

}
