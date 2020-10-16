using DungeonCrawl;
using System;
using System.Collections.Generic;

namespace Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new EditorHrdiny();
            editor.Deserializuj();
            foreach (Hrdina hrdina in editor.Objekty)
            {
                Console.WriteLine("Jmeno: " + hrdina.Jmeno);
                Console.WriteLine("Silova koskta: " +  hrdina.SilovaKostka.ToString());
                Console.WriteLine("Obratnost koskta: " + hrdina.ObratnostKostka.ToString());
                Console.WriteLine("Intelekt koskta: " + hrdina.IntelektKostka.ToString());
                Console.WriteLine("Zdravi: " + hrdina.Zdravi.ToString());
                Console.WriteLine("----------------------------------------------------------");
            }
            editor.Vytvor();
            editor.Serializuj();


            Console.ReadLine();

        }
    }
}
