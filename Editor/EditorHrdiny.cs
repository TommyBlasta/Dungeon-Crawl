
using DungeonCrawl;
using System;
using System.Collections.Generic;
using System.Text;


namespace Editor
{
    class EditorHrdiny : BazovyEditor2<Hrdina>
    {
        public EditorHrdiny()
        {
            if (Objekty == null)
            {
                Objekty = new List<Hrdina>();
            }
            Deserializuj();
        }
        override public void Vytvor()
        {
            Console.WriteLine("Zadej jméno hrdiny: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej maximální sílu hrdiny: ");
            int maxSila;
            while (!int.TryParse(Console.ReadLine(), out maxSila))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej minimální sílu hrdiny: ");
            int minSila;
            while (!int.TryParse(Console.ReadLine(), out minSila))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej maximální intelekt hrdiny: ");
            int maxIntel;
            while (!int.TryParse(Console.ReadLine(), out maxIntel))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej minimální intelekt hrdiny: ");
            int minIntel;
            while (!int.TryParse(Console.ReadLine(), out minIntel))
                Console.WriteLine("Neplatné zadání, zadej znavu: ");
            Console.WriteLine("Zadej maximální obratnost hridny: ");
            int maxObratnost;
            while (!int.TryParse(Console.ReadLine(), out maxObratnost))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej minimální obratnost hrdiny: ");
            int minObratnost;
            while (!int.TryParse(Console.ReadLine(), out minObratnost))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Kostka sila = new Kostka(minSila, maxSila);
            Kostka intelekt = new Kostka(minIntel, maxIntel);
            Kostka obratnost = new Kostka(minObratnost, maxObratnost);
            var novyHrdina = new Hrdina(jmeno, sila, intelekt, obratnost);
            Objekty.Add(novyHrdina);


        }
    }
}
