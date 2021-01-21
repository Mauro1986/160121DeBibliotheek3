using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Lid : Bezoeker
    {
        public string GeboorteDatum { get; set; }

        public List<Item> ItemsUitgeleend { get; set; } // max 5
        public List<Item> UitleenHistoriek { get; set; }
        public List<Item> Reservaties { get; set; } // max 5

        public Lid()
        {

        }
        public Lid(string voorNaam, string familieNaam, string geboorteDatum) : base(voorNaam, familieNaam)
        {
            GeboorteDatum = geboorteDatum;
            ItemsUitgeleend = new List<Item>();
            UitleenHistoriek = new List<Item>();
            //Reservaties = new List<Item>();
        }
        public Lid(string voornaam, string familienaam, string geboortedatum,  List<Item> itemsUitgeleend, List<Item> uitleenhistoriek, List<Item> reservatie) : base(voornaam, familienaam)
        {
            GeboorteDatum = geboortedatum;
            ItemsUitgeleend = itemsUitgeleend;
        }

        #region Methods
        public void Uitlenen(Item item)             //NOG WERK AAN    
        {
            Console.WriteLine("item uitgeleend en toegevoegd aan ItemsUitgeleend en UitleenHistoriek");
            ItemsUitgeleend.Add(item);
            UitleenHistoriek.Add(item);                                                                         //Maximum 5
            item.Uitgeleend = true;

            #region Validate of zoekopdracht in collectie zit maar probleem mee...
            //Console.WriteLine("Geef titel van het item dat je wilt lenen");
            //string titelZoekopdracht = Console.ReadLine();
            //bool check = true;

            //foreach (var item in CollectieBibliotheek.ItemsInCollectie)
            //{
            //    if (!(item.Titel.Contains(titelZoekopdracht)))
            //    {
            //        check = false;
            //    }

            //    else if (item.Titel.Contains(titelZoekopdracht))
            //    {
            //        check = true;
            //        Console.WriteLine($"{titelZoekopdracht} is gevonden en bij deze uitgeleend, veel plezier ermee!");
            //       // ItemsUitgeleend.Add(item);                                                                            //Toevoegen aan itemsuitgeleend gaat niet
            //        break;
            //    }
            //}
            //if (!check)
            //{
            //    Console.WriteLine($"\n'{titelZoekopdracht}' niet gevonden..."); 
            //    Uitlenen();
            //}
            #endregion      //validate of   //
        }

        public void Terugbrengen(Item item)
        {
            Console.WriteLine("Item teruggebracht waarvoor dank, item removed van ItemsUitgeleend");
            ItemsUitgeleend.Remove(item);
            item.Uitgeleend = false;
            #region Validate maar probleem mee....
            //Console.WriteLine("Geef titel van het item dat je wilt terugbrengen");
            //string titelZoekopdracht = Console.ReadLine();
            //bool check = false;
            //foreach (var item in CollectieBibliotheek.ItemsInCollectie)
            //{
            //    if (item.Titel != titelZoekopdracht)
            //    {
            //        check = false;
            //    }
            //    else
            //    {
            //        check = true;
            //        item.Uitgeleend = false;
            //        ItemsUitgeleend.Remove(item);
            //        Console.WriteLine($"Bedankt om {titelZoekopdracht} terug te brengen!");
            //        break;
            //    }
            //}
            //if (!check)
            //{
            //    Console.WriteLine($"\n'{titelZoekopdracht}' niet gevonden...");
            //}
            #endregion
        }

        public void Reserveren(Item item)
        {
            Console.WriteLine("Item Gereserveerd");
            Reservaties.Add(item);                                                                                 //Max 5

        }

        public void ShowUitgeleendeItems()                  // Moet dit uitgeleende items Lid tonen of alle uitgeleende
        {
            Console.WriteLine("Deze items zijn momenteel uitgeleend:\n");
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

        public void ShowReservaties()
        {
            //Console.WriteLine("Deze items zijn momenteel gereserveerd:\n");       //dit is niet juist maar kan me op weg helpen
            //foreach (var item in CollectieBibliotheek.ItemsInCollectie)
            //{
            //    if (item.Uitgeleend)
            //    {
            //        Console.WriteLine($"Item Id: {item.ItemId}");
            //        Console.WriteLine($"Soort Item:{item.soortItem}");
            //        Console.WriteLine($"Titel: {item.Titel}");
            //        Console.WriteLine($"Maker: {item.RegieAuteurUitvoerder}");//Zou nog moeten aangepast worden afghangelijk van soort media
            //        Console.WriteLine($"Jaartal: {item.Jaartal}");
            //        Console.WriteLine($"Uitgeleend: {item.Uitgeleend}");
            //        Console.WriteLine($"Afgevoerd: {item.Afgevoerd}");
            //        Console.WriteLine();
            //    }
            //}
        }
        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
