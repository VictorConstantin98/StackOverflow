using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Postari : Forum
    {
        private string denumirePostare;
        private Dictionary<Utilizatori, int> dictionarPostari;

        public Postari()
        {
            this.denumirePostare = "";
            dictionarPostari = new Dictionary<Utilizatori,int>();
        }

        public Postari(string denumirePostare, Dictionary<Utilizatori, int> dictionarPostari)
        {
            this.denumirePostare = denumirePostare;
            this.dictionarPostari = new Dictionary<Utilizatori, int>(dictionarPostari);
        }
        //Getter setter denumire
        public string GetDenumirePostare()
        {
            return this.denumirePostare;
        }

        public void SetDenumirePostare(string denumirePostare)
        {
            this.denumirePostare = denumirePostare;
        }

        /*
         * Metoda de adaugat utilizatori
         */
        public void adaugareUtilizator(Utilizatori utilizatorDeAdaugat)
        {
            dictionarPostari.Add(utilizatorDeAdaugat, 0);
        }

        /*
         * Metoda de adaugat utilizator si postare
         */
        public void AdaugareUtilizatorSiPostare(Utilizatori utilizatorDeAdaugat2)
        {
            int nrPostari;
            dictionarPostari.TryGetValue(utilizatorDeAdaugat2, out nrPostari);
            if(nrPostari != null)
            {
                dictionarPostari[utilizatorDeAdaugat2] = nrPostari + 1;
            }
        }

        /*
         * ToString
         */
        public override string ToString()
        {
            string postariString = denumirePostare;
            foreach (KeyValuePair<Utilizatori, int> element in dictionarPostari)
            {
                postariString = postariString + "\n" + "Utilizatorul: " + element.Key.GetNume() + " Numar postari: " + element.Value;
            }
            return postariString;
        }

        /*
         * Override metoda abstracta
         */
        public override void MentioneazaActivitateaPeForum()
        {
            Console.WriteLine("Utilizatorii de pe forum posteaza.");
        }
    }
}
