using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DungeonCrawl
{
    public class Hrdina : INotifyPropertyChanged
    {
        public Hrdina()
        {

        }
        public int Zdravi { get; set; }
        public string Jmeno { get; set; }
        public Kostka SilovaKostka { get; set; }
        public Kostka IntelektKostka { get; set; }
        public Kostka ObratnostKostka { get; set; }
        public Hrdina(string jmeno, Kostka sila, Kostka intelekt, Kostka obratnost)
        {
            Zdravi = 100;
            Jmeno = jmeno;
            SilovaKostka = sila;
            IntelektKostka = intelekt;
            ObratnostKostka = obratnost;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Utok()
        {

        }
        public void Obrana()
        {

        }
    }
}
