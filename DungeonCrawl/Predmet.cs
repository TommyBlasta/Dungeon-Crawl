using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl
{
    public class Predmet
    {
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
    }
}
