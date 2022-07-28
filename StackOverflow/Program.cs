using System;
namespace StackOverflow
{
    class Program
    {
        static void Main (string[] args)
        {
            Utilizatori utilizatori = new Utilizatori();
            utilizatori.MentioneazaActivitateaPeForum();

            Categorie intrebariSiRaspunsuri = new Categorie("Intrebari si raspunsuri");
            intrebariSiRaspunsuri.MentioneazaActivitateaPeForum();
            Console.WriteLine(intrebariSiRaspunsuri.ToString());
            Dictionary<Utilizatori, int> dictionarPostari1 = new Dictionary<Utilizatori, int>();

            Utilizatori utilizator1 = new Utilizatori("Dev1", new DateTime(2022, 5, 12));

            Postari postare1 = new Postari("Intrebare", dictionarPostari1);
            postare1.adaugareUtilizator(utilizator1);
            Console.WriteLine();

            
        }
    }
}
