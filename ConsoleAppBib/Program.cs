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
            #region INPUT                               
                                                      //Bekijk Solid principe nog is om beter toe te passen (single en factory patrn vooral deze laatste)
            Item item001 = new Item()
            {
                Titel = "De GVR",
                RegieAuteurUitvoerder = "Shaquille O'Neil",
                ItemId = "1",
                soortItem = ClassLibrary.Models.SoortItem.Boek,
                Jaartal = 2000,
                Uitgeleend = false,
                Afgevoerd = false
            };            //zulke zaken in class 
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
                Uitgeleend = true,
                Afgevoerd = false
            };
            Bezoeker bez001 = new Bezoeker()
            {
                VoorNaam = "Jeff",
                FamilieNaam = "Van Om Den Hoek"
            };
            Lid lid001 = new Lid()
            {
                VoorNaam = "Mauro",
                FamilieNaam = "Gay",
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
            #endregion


            #region MENU
            Bezoeker nieuweBezoeker = new Bezoeker();

            Console.WriteLine("Hallo en welkom in onze vernieuwde Bibliotheek-console\n" +
            "Hoe wilt u zich aanmelden:\nA)LID\nB)MEDEWERKER\nC)BEZOEKER");

            ConsoleKey instructionKey = Console.ReadKey().Key;          //indien er gekozen word voor inloggen->toon overzicht leden of medewerkers(naargelang inlog-optie)
            Console.Clear();
            switch (instructionKey)
            {
                #region SWITCH CASE LIDMENU
                case ConsoleKey.A:
                    Console.WriteLine("A)LID:\n");      //Hier moet ik nog zorgen dat ik kan inloggen als lid
                    Console.WriteLine($"Hallo Lid {lid001.VoorNaam}, \n(ter info:hier moet ik nog zorgen voor lid uit lijst te selecteren,\n voorlopig gaat programma verder met Mauro Gay als Lid)");
                    Console.WriteLine("\nWat wil je doen:\n" +
                       "A)Zoek een Item op Titel of op item Id\n" +
                       "B)Toon overzichten\n" +
                       "C)Leen item uit\n" +
                       "D)Reserveer een item\n" +
                       "E)Breng item terug\n" +
                       "F)Bekijk uitleenhistoriek\n" +
                       "G)Bekijk uitgeleende items\n" +
                       "H)Bekijk gereserveerde items\n");
                    ConsoleKey instructionKeyLid = Console.ReadKey().Key;
                    Console.Clear();
                    switch (instructionKeyLid)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("A)Zoek een Item op Titel of op item Id\n");
                            lid001.ZoekItem();
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("B)Toon overzichten\n");
                            lid001.ToonOverzicht();
                            break;

                        case ConsoleKey.C:
                            Console.WriteLine("C)Leen item uit\n");
                            Console.WriteLine("(ter info, momenteel lukt het enkel bij invoeren van item variabel naam vb item001)");
                            Console.WriteLine("Voorlopig gaat het programma verder met item001");
                            lid001.Uitlenen(item001);
                            break;

                        case ConsoleKey.D:
                            Console.WriteLine("D)Reserveer een item\n");
                            Console.WriteLine("(ter info, momenteel lukt het enkel bij invoeren van item variabel naam vb item002)");
                            Console.WriteLine("Voorlopig gaat het programma verder met item002");
                            lid001.Reserveren(item002);
                            break;

                        case ConsoleKey.E:
                            Console.WriteLine("E)Breng item terug\n");
                            Console.WriteLine("(ter info, momenteel lukt het enkel bij invoeren van item variabel naam vb item001)");
                            Console.WriteLine("Voorlopig gaat het programma verder met item001");
                            lid001.Terugbrengen(item001);
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine("F)Bekijk uitleenhistoriek\n");
                            Console.WriteLine("tip: zolang niets uitgeleend is via methode, blijft lijst leeg");
                            Console.WriteLine(lid001.UitleenHistoriek);
                            break;

                        case ConsoleKey.G:
                            Console.WriteLine("G)Bekijk uitgeleende items\n");
                            lid001.ShowUitgeleendeItems();
                            break;

                        case ConsoleKey.H:
                            Console.WriteLine("H)Bekijk gereserveerde items\n");
                            lid001.ShowReservaties();
                            break;
                    }
                    break;
                #endregion

                #region SWITCH CASE MEDEWERKERMENU
                case ConsoleKey.B:
                    Console.WriteLine("B)MEDEWERKER:\n");
                    Console.WriteLine($"Hallo Medewerker {medewerker001.VoorNaam}, \n(ter info:hier moet ik nog zorgen voor medewerker uit lijst te selecteren,\n voorlopig gaat programma verder met Den Joe Biden als Medewerker)");
                    Console.WriteLine("\nWat wil je doen:\n" +
                       "A)Zoek een Item op Titel of op item Id\n" +
                       "B)Toon overzichten\n" +
                       "C)Leen item uit\n" +
                       "D)Reserveer een item\n" +
                       "E)Breng item terug\n" +
                       "F)Bekijk uitleenhistoriek\n" +
                       "G)Bekijk uitgeleende items\n" +
                       "H)Bekijk gereserveerde items\n" +
                       "I)Promoveer lid naar medewerker\n" +
                       "J)Voeg Item toe aan de collectie\n" +
                       "K)Voer een item af uit de collectie\n"
                       );
                    ConsoleKey instructionKeyMedewerker = Console.ReadKey().Key;
                    Console.Clear();
                    switch (instructionKeyMedewerker)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("A)Zoek een Item op Titel of op item Id\n");
                            medewerker001.ZoekItem();
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("B)Toon overzichten\n");
                            medewerker001.ToonOverzicht();
                            break;

                        case ConsoleKey.C:
                            Console.WriteLine("C)Leen item uit\n");
                            Console.WriteLine("(ter info, momenteel lukt het enkel bij invoeren van item variabel naam vb item001)");
                            Console.WriteLine("Voorlopig gaat het programma verder met item001");
                            medewerker001.Uitlenen(item001);
                            break;

                        case ConsoleKey.D:
                            Console.WriteLine("D)Reserveer een item\n");
                            Console.WriteLine("(ter info, momenteel lukt het enkel bij invoeren van item variabel naam vb item002)");
                            Console.WriteLine("Voorlopig gaat het programma verder met item002");
                            medewerker001.Reserveren(item002);
                            break;

                        case ConsoleKey.E:
                            Console.WriteLine("E)Breng item terug\n");
                            Console.WriteLine("(ter info, momenteel lukt het enkel bij invoeren van item variabel naam vb item001)");
                            Console.WriteLine("Voorlopig gaat het programma verder met item001");
                            medewerker001.Terugbrengen(item001);
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine("F)Bekijk uitleenhistoriek\n");
                            Console.WriteLine("tip: zolang niets uitgeleend is via methode, blijft lijst leeg");
                            Console.WriteLine(medewerker001.UitleenHistoriek);
                            break;

                        case ConsoleKey.G:
                            Console.WriteLine("G)Bekijk uitgeleende items\n");
                            medewerker001.ShowUitgeleendeItems();
                            break;

                        case ConsoleKey.H:
                            Console.WriteLine("H)Bekijk gereserveerde items\n");
                            medewerker001.ShowReservaties();
                            break;

                        case ConsoleKey.I:
                            Console.WriteLine("I)Promoveer lid naar medewerker\n");
                            medewerker001.PromoveerLidNaarMedeweker();
                            break;

                        case ConsoleKey.J:
                            Console.WriteLine("J)Voeg Item toe aan de collectie\n");
                            medewerker001.VoegItemToe();
                            break;

                        case ConsoleKey.K:
                            Console.WriteLine("K)Voer een item af uit de collectie\n");
                            medewerker001.VoerItemAf();
                            break;
                    }
                    break;
                #endregion

                #region SWITCH CASE BEZOEKERMENU
                case ConsoleKey.C:
                    Console.WriteLine("C)BEZOEKER:\n");
                    Console.WriteLine("Geef je familienaam:");
                    nieuweBezoeker.FamilieNaam = Console.ReadLine();
                    Console.WriteLine("\nGeef je voornaam:");
                    nieuweBezoeker.VoorNaam = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine(nieuweBezoeker.VoorNaam);
                    Console.WriteLine("Wat wil je doen:\n" +
                        "A)Registreer als Lid\n" +
                        "B)Zoek een Item op Titel of op item Id\n" +
                        "C)Toon overzichten");                              //verwijst naar submenu om soort overzicht te kiezen(4)
                    ConsoleKey instructionKeyBezoeker = Console.ReadKey().Key;
                    Console.Clear();
                    switch (instructionKeyBezoeker)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("A)Registreer als Lid:\n");
                            Console.WriteLine("Geef je geboortedatum");
                            string geboortedatum = Console.ReadLine();
                            nieuweBezoeker.RegistreerLid(geboortedatum);
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("B)Zoek een Item op titel of ItemId\n");
                            nieuweBezoeker.ZoekItem();
                            break;

                        case ConsoleKey.C:
                            Console.WriteLine("C)Toon overzichten\n");
                            nieuweBezoeker.ToonOverzicht();
                            break;
                    }

                    break;
                    //default:
                    //    endApp = true;
                    //    break;
                    #endregion
            }

            #endregion


            //EVENTUEEL OM LIJSTEN WEG TE SCHRIJVEN NAAR TEKSTBESTANDEN
            //Voor een Item aan Textfile Afgevoerde items toe te voegen, eerst method  VoerItemAf uitvoeren
            #region Write list To TextFile ItemsInCollectie, Afgevoerde Items, Leden
            //string fileAdresItemsInCollectie = @"C:\Users\Mauro\OneDrive\Bureaublad\Intec\temp\ItemsInCollectie.txt";
            //List<string> output1 = new List<string>();
            //foreach (var item in CollectieBibliotheek.ItemsInCollectie)
            //{
            //    output1.Add($"{item.Titel},{item.RegieAuteurUitvoerder},{item.ItemId},{item.soortItem},{item.Jaartal},{item.Uitgeleend},{item.Afgevoerd}");
            //}
            //File.WriteAllLines(fileAdresItemsInCollectie, output1);

            //string fileAdresAfgevoerdeItems = @"C:\Users\Mauro\OneDrive\Bureaublad\Intec\temp\afgevoerdeItems.txt";
            //List<string> output2 = new List<string>();
            //foreach (var item in CollectieBibliotheek.AfgevoerdeItems)
            //{
            //    output2.Add($"{item.Titel},{item.RegieAuteurUitvoerder},{item.ItemId},{item.soortItem},{item.Jaartal},{item.Uitgeleend},{item.Afgevoerd}");
            //}
            //File.WriteAllLines(fileAdresAfgevoerdeItems, output2);

            //string fileAdresLeden = @"C:\Users\Mauro\OneDrive\Bureaublad\Intec\temp\Leden.txt";
            //List<string> output3 = new List<string>();
            //foreach (var item in CollectieBibliotheek.Leden)
            //{
            //    output3.Add($"{item.VoorNaam},{item.FamilieNaam},{item.GeboorteDatum}{item.ItemsUitgeleend}");
            //}
            //File.WriteAllLines(fileAdresLeden, output3);

            #endregion
        }
    }
}
