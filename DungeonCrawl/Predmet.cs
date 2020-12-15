using DungeonCrawl.Enums;
using DungeonCrawl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl
{
    public class Predmet : IInterakce
    {
        public ItemFlags ItemFlags { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public int ID { get; set; }
        public Predmet()
        {

        }
        public Predmet(string nazev, string popis, int id)
        {
            Nazev = nazev;
            Popis = popis;
            ID = id;
        }

        virtual public ControllerCommand Interakce()
        {
            if(this.ItemFlags.HasFlag(ItemFlags.TextVypis))
            {
                return new ControllerCommand()
                {
                    AkceKProvedeni = AkceController.ProzkoumejPredmet,
                    ObjektyKInterakci = null,
                    TextInterakce = Popis
                };
            }
            else
            {
                return null;
            }
        }
    }
}
