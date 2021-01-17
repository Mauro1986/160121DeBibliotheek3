using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Bezoeker 
    {
        public string VoorNaam { get; set; }
        public string FamilieNaam { get; set; }

        public Bezoeker(string voorNaam, string familieNaam)
        {
            voorNaam = VoorNaam;
            familieNaam = FamilieNaam;
        }

        public Bezoeker()
        {

        }

        #region Methods

        public void RegistreerLid(string geboorteDatum)
        {
            CollectieBibliotheek.Leden.Add(new Lid(VoorNaam, FamilieNaam, geboorteDatum));
            Console.WriteLine("Registratie voltooid, u staat op de Ledenlijst");
        }

        public void ZoekItem()                //Uitleg vragen wat precies verschil is met public Item ZoekItem()
        {
            Console.WriteLine("Wilt u op\nA)titel of op \nB)Item Id zoeken?");
            string titelOfId = Console.ReadLine();
            if (titelOfId.ToUpper() == "A")
            {
                Console.WriteLine("Geef titel");
                string titelZoekopdracht = Console.ReadLine();
                bool check = false;
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    if (item.Titel != titelZoekopdracht)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine($"\nTitel '{titelZoekopdracht}' gevonden!");        //eventueel alle gegevens tonen
                }
                else
                {
                    Console.WriteLine($"\n'{titelZoekopdracht}' niet gevonden...");
                }
            }
            else if (titelOfId.ToUpper() == "B")
            {
                Console.WriteLine("Geef Item Id");
                string itemIdZoekopdracht = Console.ReadLine();
                bool check = false;
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    if (item.ItemId != itemIdZoekopdracht)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine($"\nId: '{itemIdZoekopdracht}' gevonden!");        //eventueel alle gegevens tonen
                }
                else
                {
                    Console.WriteLine($"\n'{itemIdZoekopdracht}' niet gevonden...");
                }
            }
        }

        public void ToonOverzicht()             //Zou nog moeten aangepast worden afghangelijk van soort media(4 plaatsen)
        {
            Console.WriteLine("Welk overzicht wilt u bekijken:" +
                "\n1) Alle media uit colletie" +
                "\n2) Alle afgevoerde media" +
                "\n3) Alle beschikbare (niet uitgeleende) media" +
                "\n4) Alle niet-beschikbare (uitgeleende) media");
            string keuzeOverzicht = Console.ReadLine();
            if (keuzeOverzicht == "1")
            {
                Console.WriteLine("Alle media");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    Console.WriteLine($"Item Id: {item.ItemId}");
                    Console.WriteLine($"Soort Item:{item.soortItem}");
                    Console.WriteLine($"Titel: {item.Titel}");
                    Console.WriteLine($"Maker: {item.RegieAuteurUitvoerder}");  //1
                    Console.WriteLine($"Jaartal: {item.Jaartal}");
                    Console.WriteLine($"Uitgeleend: {item.Uitgeleend}");
                    Console.WriteLine($"Afgevoerd: {item.Afgevoerd}");
                    Console.WriteLine();
                }
            }
            else if (keuzeOverzicht == "2")
            {
                Console.WriteLine("Afgevoerde media:\n");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    if (item.Afgevoerd)
                    {
                        Console.WriteLine($"Item Id: {item.ItemId}");
                        Console.WriteLine($"Soort Item:{item.soortItem}");
                        Console.WriteLine($"Titel: {item.Titel}");
                        Console.WriteLine($"Maker: {item.RegieAuteurUitvoerder}");//Zou nog moeten aangepast worden afghangelijk van soort media
                        Console.WriteLine($"Jaartal: {item.Jaartal}");
                        Console.WriteLine($"Uitgeleend: {item.Uitgeleend}");
                        Console.WriteLine($"Afgevoerd: {item.Afgevoerd}");
                        Console.WriteLine();
                    }
                }
            }
            else if (keuzeOverzicht == "3")
            {
                Console.WriteLine("Beschikbare media(niet uitgeleend):\n");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    if (!item.Uitgeleend)
                    {
                        Console.WriteLine($"Item Id: {item.ItemId}");
                        Console.WriteLine($"Soort Item:{item.soortItem}");
                        Console.WriteLine($"Titel: {item.Titel}");
                        Console.WriteLine($"Maker: {item.RegieAuteurUitvoerder}");//Zou nog moeten aangepast worden afghangelijk van soort media
                        Console.WriteLine($"Jaartal: {item.Jaartal}");
                        Console.WriteLine($"Uitgeleend: {item.Uitgeleend}");
                        Console.WriteLine($"Afgevoerd: {item.Afgevoerd}");
                        Console.WriteLine();
                    }
                }
            }
            else if (keuzeOverzicht == "4")
            {
                Console.WriteLine("Niet beschikbare media(uitgeleend):\n");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    if (item.Uitgeleend)
                    {
                        Console.WriteLine($"Item Id: {item.ItemId}");
                        Console.WriteLine($"Soort Item:{item.soortItem}");
                        Console.WriteLine($"Titel: {item.Titel}");
                        Console.WriteLine($"Maker: {item.RegieAuteurUitvoerder}");//Zou nog moeten aangepast worden afghangelijk van soort media
                        Console.WriteLine($"Jaartal: {item.Jaartal}");
                        Console.WriteLine($"Uitgeleend: {item.Uitgeleend}");
                        Console.WriteLine($"Afgevoerd: {item.Afgevoerd}");
                        Console.WriteLine();
                    }
                }
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
