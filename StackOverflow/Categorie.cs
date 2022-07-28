using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Categorie : Forum
    {
        private string denumireCategorie;

        public Categorie(string denumireCategorie)
        {
            this.denumireCategorie = denumireCategorie;
        }

        //Getter si setter denumireCategorie
        public string GetDenumireCategorie()
        {
            return this.denumireCategorie;
        }

        public void SetDenumireCategorie(string denumireCategorie)
        {
            this.denumireCategorie = denumireCategorie;
        }
        /*
         * ToString
         */
        public override string ToString()
        {
            string categorieString = "";
            categorieString = categorieString + "Denumirea categoriei este: " + GetDenumireCategorie();
            return categorieString;
        }

        /*
         * Override metoda abstracta
         */
        public override void MentioneazaActivitateaPeForum()
        {
            Console.WriteLine("Utilizatorii posteaza in diferite categorii pe forum."); 
        }
    }
}
