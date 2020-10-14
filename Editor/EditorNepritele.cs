using System;
using System.Collections.Generic;
using System.Text;
using DungeonCrawl;

namespace Editor
{
    class EditorNepritele : BazovyEditor<Nepritel>
    {
        public EditorNepritele()
        {
            if (Objekty == null)
            {
                Objekty = new List<Nepritel>();
            }
            Deserializuj();
        }
        override public void Vytvor()
        {
            Console.WriteLine("Zadej jméno nepřítele: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej zdraví nepřítele: ");
            int zdravi;
            while (!int.TryParse(Console.ReadLine(), out zdravi))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej minimální útok nepřítele: ");
            int minutok;
            while (!int.TryParse(Console.ReadLine(), out minutok))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej maximální útok nepřítele: ");
            int maxutok;
            while (!int.TryParse(Console.ReadLine(), out maxutok))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej minimální obranu nepřítele: ");
            int minobrana;
            while (!int.TryParse(Console.ReadLine(), out minobrana))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Console.WriteLine("Zadej maximální obranu nepřítele: ");
            int maxobrana;
            while (!int.TryParse(Console.ReadLine(), out maxobrana))
                Console.WriteLine("Neplatné zadání, zadej znovu: ");
            Kostka utok = new Kostka(minutok, maxutok);
            Kostka obrana = new Kostka(minobrana, maxobrana);
            var novyNepritel = new Nepritel(jmeno, zdravi, utok, obrana);
            Objekty.Add(novyNepritel);
        }
    }
}
