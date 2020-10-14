using DungeonCrawl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Editor
{
    class EditorPredmetu : BazovyEditor<Predmet>
    {
        public EditorPredmetu()
        {
            if (Objekty == null)
            {
                Objekty = new List<Predmet>();
            }
            Deserializuj();   
        }
        public override void Vytvor()
        {
            Console.WriteLine("Zadej název předmětu: ");
            string nazev = Console.ReadLine();
            Console.WriteLine("Zadej popis předmětu: ");
            string popis = Console.ReadLine();
            int id = 0;
            foreach (Predmet predmet in Objekty)
            {
                if (predmet.ID > id)
                {
                    id = predmet.ID;
                }
            }
            var novyPredmet = new Predmet(nazev, popis, id + 1);
            Objekty.Add(novyPredmet);
        }       
    }
}
