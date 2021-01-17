using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
   public static class CollectieBibliotheek
    {
        public static List<Lid> Leden = new List<Lid>();                    //Dynamisch te vullen bij elke Get

        public static List<Item> ItemsInCollectie = new List<Item>();

        public static List<Item> AfgevoerdeItems = new List<Item>();
    }
}
