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
        //collectie UitleenHistoriek
        //collectie Reservatie(max 5)

        public Lid()
        {

        }
        public Lid(string voorNaam, string familieNaam, string geboorteDatum) : base(voorNaam, familieNaam)
        {
            GeboorteDatum = geboorteDatum;
        }

        #region Methods
        public void Uitlenen()         //item item? void?               //NOG WERK AAN    
        {
            Console.WriteLine("Geef titel van het item dat je wilt lenen");
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
                    item.Uitgeleend = true;
                    ItemsUitgeleend.Add(item);
                    Console.WriteLine($"{titelZoekopdracht} is nu uitgeleend, veel plezier ermee");
                    //foreach (var itemm in ItemsUitgeleend)
                    //{
                    //    Console.WriteLine("Lijst uitgeleende items");
                    //    Console.WriteLine(item.Titel);
                    //    Console.WriteLine();
                    //}
                    //break;
                }
            }
            if (check)
            {
                Console.WriteLine($"\nTitel '{titelZoekopdracht}' gevonden!");        //eventueel alle gegevens tonen

            }
            else
            {
                Console.WriteLine($"\n'{titelZoekopdracht}' niet gevonden...");
                Uitlenen();
            }

        }

        public void Terugbrengen()//Item item
        {
            Console.WriteLine("Geef titel van het item dat je wilt terugbrengen");
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
                    item.Uitgeleend = false;
                    Console.WriteLine($"{titelZoekopdracht} is nu uitgeleend, veel plezier ermee");
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine($"\n'{titelZoekopdracht}' niet gevonden...");
            }
        }

        public void Reserveren()
        {

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
