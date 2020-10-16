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
                Console.WriteLine(hrdina.SilovaKostka.ToString());
                Console.WriteLine(hrdina.ObratnostKostka.ToString());
                Console.WriteLine(hrdina.IntelektKostka.ToString());
                Console.WriteLine(hrdina.Zdravi.ToString());
            }
            editor.Vytvor();
            editor.Serializuj();


            Console.ReadLine();

        }
    }
}
