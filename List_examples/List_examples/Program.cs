using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //String txt hvor der er defineret en tekst
            string txt = " Nisser på landet skider i kornet";
            //"List" er datatypen, "<string>" er også datatypen "ordliste" er listens navn.
            //"new List" opretter en ny liste.
            //"txt.Split(' ')" sørger for at der bliver splittet efter hvert mellemrum
            List<string> ordliste = new List<string>(txt.Split(' '));

            //Tilføjer til listen "ordliste"
            ordliste.Add("Kim Bodnia");
            //kigger om listen inderholder "Kim"
            ordliste.Contains("Kim");

            //for hver string i "delOrd" i "ordliste" udskriv nedstående
            foreach (string delOrd in ordliste)
            {
                Console.WriteLine("Delord : " + delOrd);
            }

            Console.ReadKey();
        }
    }
}
