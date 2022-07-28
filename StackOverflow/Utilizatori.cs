using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Utilizatori : Forum
    {
        private string numeUtilizatori;
        private DateTime vechimeaPeForum;

        public Utilizatori()
        {

        }

        public Utilizatori(string numeUtilizatori, DateTime vechimeaPeForum)
        {
            this.numeUtilizatori = numeUtilizatori;
            this.vechimeaPeForum = vechimeaPeForum;
        }

        //Getteri si setteri

        public string GetNume()
        {
            return this.numeUtilizatori;
        }

        public void SetNume(string numeUtilizatori)
        {
            this.numeUtilizatori = numeUtilizatori;
        }

        public DateTime GetVechimeaPeForum()
        {
            return this.vechimeaPeForum;
        }

        public void SetVechimeaPeForum(DateTime vechimeaPeForum)
        {
            this.vechimeaPeForum = vechimeaPeForum;
        }

        /*
         * ToString
         */
        public override string ToString()
        {
            string afisareString = "";
            afisareString = afisareString + "Nume: " + numeUtilizatori + "Data inregistrarii pe forum: " + vechimeaPeForum;
            return afisareString;
        }

        /*
         * Override metoda abstracta
         */

        public override void MentioneazaActivitateaPeForum()
        {
            Console.WriteLine("Pe forum sunt logati utilizatori.");
        }

    }
}
