using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl
{
    public class Nepritel
    {
        public Nepritel()
        {

        }
        public int Zdravi { get; set; }
        public string Jmeno { get; set; }
        public Kostka UtocnaKostka { get; set; }
        public Kostka ObrannaKostka { get; set; }

        public Nepritel(string jmeno, int zdravi, Kostka utok, Kostka obrana)
        {
            Jmeno = jmeno;
            Zdravi = zdravi;
            UtocnaKostka = utok;
            ObrannaKostka = obrana;
        }
        public void Utok()
        {

        }
        public void Obrana()
        {

        }
    }
}
