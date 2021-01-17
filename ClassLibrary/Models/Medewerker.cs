using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Medewerker : Lid
    {
        #region Methods
        public void PromoveerLidNaarMedeweker()       //nog zorgen dat counter zorgt voor nieuwemedewerkernaam++1
        {
            Console.WriteLine("Welk lid wil je promoveren tot mederwerker:\n" +
                "Geef familienaam:");
            string familienaam = Console.ReadLine();
            Console.WriteLine("Geef voornaam:");
            string voornaam = Console.ReadLine();

            foreach (var item in CollectieBibliotheek.Leden)
            {
                if (item.VoorNaam == voornaam && item.FamilieNaam == familienaam)
                {
                    Console.WriteLine($"Proficiat {item.VoorNaam}\nJe bent nu een medewerker van de bib");
                    Console.WriteLine();
                }
            }
            Medewerker nieuwemedewerker = new Medewerker()
            {
                FamilieNaam = familienaam,
                VoorNaam = voornaam,
                GeboorteDatum = GeboorteDatum
            };
            nieuwemedewerker.GeefOverzichtLeden();
        }

        public void VoerItemAf()
        {
            Console.WriteLine("Geef titel van het item dat je wilt afvoeren");
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
                    item.Afgevoerd = true;
                    CollectieBibliotheek.AfgevoerdeItems.Add(item);
                    CollectieBibliotheek.ItemsInCollectie.Remove(item);
                    Console.WriteLine($"{titelZoekopdracht} is nu afgevoerd(Removed van ItemsCollectie en toegevoegd aan AfgevoerdeItems ");
                    break;
                }
            }
            if (check)
            {
                // Console.WriteLine($"\nTitel '{titelZoekopdracht}' gevonden!");        //eventueel alle gegevens tonen
            }
            else
            {
                Console.WriteLine($"\n'{titelZoekopdracht}' niet gevonden...");
            }
        }

        public void VoegItemToe()
        {
            string titel;
            string regieauteuruitvoerder;
            string itemId;
            //SoortItem soortitem;
            int jaartal;
            bool uitgeleend;
            bool afgevoerd;

            Console.WriteLine("Item toevoegen aan collectie" +
                "\nVoer item gegevens in:" +
                "\nTitel:");
            titel = Console.ReadLine();
            Console.WriteLine("Maker:");
            regieauteuruitvoerder = Console.ReadLine();
            Console.WriteLine("Item Id:");
            itemId = Console.ReadLine();
            Console.WriteLine("Soort Item:lukt nog niet");          //moet enum kunnen ingeven
            //soortitem = Convert. Console.ReadLine(); 
            //soortitem = SoortItem.
            Console.WriteLine("Jaartal:");
            jaartal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uitgeleed(true/false):");
            uitgeleend = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Afgevoerd(true/false):");
            afgevoerd = Convert.ToBoolean(Console.ReadLine());

            Item item003 = new Item()                                       //ID generator nog maken
            {
                Titel = titel,
                RegieAuteurUitvoerder = regieauteuruitvoerder,
                ItemId = itemId,
                //soortItem = ClassLibrary.Models.SoortItem.Boek,
                Jaartal = jaartal,
                Uitgeleend = uitgeleend,
                Afgevoerd = afgevoerd
            };
            CollectieBibliotheek.ItemsInCollectie.Add(item003);
        }               //nog zorgen datsoort item toevoegen (enum) 

        public void GeefOverzichtLeden()
        {
            Console.WriteLine("Overzicht Leden:\n");
            foreach (var item in CollectieBibliotheek.Leden)
            {
                Console.WriteLine($"{item.VoorNaam} {item.FamilieNaam} {item.GeboorteDatum}\n");
            }
        }
        #endregion
    }
}
