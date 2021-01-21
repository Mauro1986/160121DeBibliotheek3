using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
using System.IO;

namespace ConsoleAppBib
{
    class Program
    {
        static void Main(string[] args)
        {
            //MENU komt hieronder

            #region tijdelijke testcode
            //TESTING TEMP CODE

            Item item001 = new Item()
            {
                Titel = "De GVR",
                RegieAuteurUitvoerder = "Shaquille O'Neil",
                ItemId = "1",
                soortItem = ClassLibrary.Models.SoortItem.Boek,
                Jaartal = 2000,
                Uitgeleend = false,
                Afgevoerd = false
            };
            Item item002 = new Item()
            {
                Titel = "The Last Dance",
                RegieAuteurUitvoerder = "Michael Jordan",
                ItemId = "2",
                soortItem = ClassLibrary.Models.SoortItem.DVD,
                Jaartal = 1995,
                Uitgeleend = false,
                Afgevoerd = false
            };
            Item item003 = new Item()
            {
                Titel = "Suske & Wiske",
                RegieAuteurUitvoerder = "Willy Vandersteen",
                ItemId = "3",
                soortItem = ClassLibrary.Models.SoortItem.Stripverhaal,
                Jaartal = 1999,
                Uitgeleend = false,
                Afgevoerd = false
            };
            Bezoeker bez001 = new Bezoeker()
            {
                VoorNaam = "Dejeff",
                FamilieNaam = "Van Om Den Hoek"
            };
            Lid lid001 = new Lid()
            {
                VoorNaam = "Mauro",
                FamilieNaam = "G",
                GeboorteDatum = "18 12 1986"
            };
            Medewerker medewerker001 = new Medewerker()
            {
                VoorNaam = "Den Joe",
                FamilieNaam = "Biden",
                GeboorteDatum = "10 01 1960"
            };

            CollectieBibliotheek.ItemsInCollectie.Add(item001);
            CollectieBibliotheek.ItemsInCollectie.Add(item002);
            CollectieBibliotheek.ItemsInCollectie.Add(item003);
            CollectieBibliotheek.Leden.Add(lid001);
            CollectieBibliotheek.Leden.Add(medewerker001);


            //TESTING TEMP CODE

            //TEST METHODS

            Console.WriteLine("Alle Leden:");
            foreach (var item in CollectieBibliotheek.Leden)
            {
                Console.WriteLine(item.VoorNaam);
                Console.WriteLine(item.FamilieNaam);
                Console.WriteLine(item.GeboorteDatum);
                Console.WriteLine();
            }
            Console.WriteLine("Alle Items:    ");
            foreach (var item in CollectieBibliotheek.ItemsInCollectie)
            {
                Console.WriteLine(item.Titel);
                Console.WriteLine(item.RegieAuteurUitvoerder);
                Console.WriteLine(item.Jaartal);
                Console.WriteLine(item.Uitgeleend);
                Console.WriteLine(item.Afgevoerd);
                Console.WriteLine();
            }

            //Console.WriteLine(CollectieBibliotheek.Leden);
            //medewerker001.ToonOverzicht();
            //medewerker001.VoegItemToe();
            //medewerker001.Reservaties.Add(item001);
            //medewerker001.ToonOverzicht();

            // lid001.RegistreerLid("1812");
            // lid001.ZoekItem();
            //bez001.ZoekItem();
            // bez001.ToonOverzicht();
            //lid001.ShowUitgeleendeItems();

            //// test uitlenen en terugbrengen
            //lid001.ToonOverzicht();
            //Console.WriteLine("-------------");
            //lid001.Uitlenen(item001);
            //Console.WriteLine("-------------");
            //lid001.Terugbrengen(item001);
            //lid001.ToonOverzicht();
            //Console.WriteLine("-------------");

            //Console.WriteLine("---------");
            //lid001.ToonOverzicht();
            //lid001.Terugbrengen();
            //Console.WriteLine("---------");
            //lid001.ToonOverzicht();

            //medewerker001.PromoveerLidNaarMedeweker();

            //medewerker001.GeefOverzichtLeden();
            //medewerker001.ToonOverzicht();
            //Console.WriteLine("***********");
            //medewerker001.Uitlenen();
            //medewerker001.ToonOverzicht();
            //Console.WriteLine("***********");
            ////medewerker001.VoerItemAf();
            ////Console.WriteLine("item afgevoerd");
            //Console.WriteLine(medewerker001.UitleenHistoriek);

            #endregion

            //Voor Item aan Textfile Afgevoerde items, eerst method  VoerItemAf uitvoeren
            #region Write list To TextFile ItemsInCollectie, Afgevoerde Items, Leden
            string fileAdresItemsInCollectie = @"C:\temp\TekstBestandenBib\ItemsInCollectie.txt";
            List<string> output1 = new List<string>();
            foreach (var item in CollectieBibliotheek.ItemsInCollectie)
            {
                output1.Add($"{item.Titel},{item.RegieAuteurUitvoerder},{item.ItemId},{item.soortItem},{item.Jaartal},{item.Uitgeleend},{item.Afgevoerd}");
            }
            File.WriteAllLines(fileAdresItemsInCollectie, output1);

            string fileAdresAfgevoerdeItems = @"C:\temp\TekstBestandenBib\afgevoerdeItems.txt";
            List<string> output2 = new List<string>();
            foreach (var item in CollectieBibliotheek.AfgevoerdeItems)
            {
                output2.Add($"{item.Titel},{item.RegieAuteurUitvoerder},{item.ItemId},{item.soortItem},{item.Jaartal},{item.Uitgeleend},{item.Afgevoerd}");
            }
            File.WriteAllLines(fileAdresAfgevoerdeItems, output2);

            string fileAdresLeden = @"C:\temp\TekstBestandenBib\Leden.txt";
            List<string> output3 = new List<string>();
            foreach (var item in CollectieBibliotheek.Leden)
            {
                output3.Add($"{item.VoorNaam},{item.FamilieNaam},{item.GeboorteDatum}{item.ItemsUitgeleend}");
            }
            File.WriteAllLines(fileAdresLeden, output3);

            #endregion
        }
    }
}
