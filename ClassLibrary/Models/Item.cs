﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public enum SoortItem
    {
        Boek,
        Stripverhaal,
        DVD,
        CD
    }

    public class Item //:Icomparable (impl, zie oefeningen)
    {
        public SoortItem soortItem { get; set; }      

        public string ItemId { get; set; }
        public string Titel { get; set; }
        public int Jaartal { get; set; }
        public bool Uitgeleend { get; set; }
        public bool Afgevoerd { get; set; }

        public string RegieAuteurUitvoerder { get; set; }      //TO DO  zou naargelang soort item moeten veranderen

        //private string soortMaker;                              //Werkt niet

        //public string SoortMaker
        //{
        //    get => soortMaker;
        //    set
        //    {
        //        //if (soortMaker == "Boek")
        //        //{
        //        //    SoortItem soort = (SoortItem)0;

        //        //}
        //        //else if (soortMaker == "Stripverhaal")
        //        //{
        //        //    SoortItem stripverhaal = (SoortItem)1;
        //        //}
        //        //else if (soortMaker == "DVD")
        //        //{
        //        //    SoortItem dvd = (SoortItem)2;
        //        //}
        //        //if (soortMaker == "CD")
        //        //{
        //        //    SoortItem cd = (SoortItem)3;
        //        //}

        //        //var input = Enum.Parse(typeof(SoortItem), soortMaker);
        //    }
        //}

    }
}
