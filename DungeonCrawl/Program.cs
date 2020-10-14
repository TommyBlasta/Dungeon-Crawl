using System;
using System.Collections.Generic;

namespace DungeonCrawl
{
    class Program
    {
        static void Main(string[] args)
        {


            //var kostka = new Kostka(1,6);
            //Console.WriteLine(kostka.Hod());
            //Console.WriteLine(kostka.Hod());
            //Console.WriteLine(kostka.Hod());
            //kostka.Zmen(2, 2);
            //Console.WriteLine(kostka.Hod());
            //Console.WriteLine(kostka.Hod());
            //Console.WriteLine(kostka.Hod());
            //Console.ReadKey();
            //var hrdina = new Hrdina("bobo", new Kostka(1, 6), new Kostka(1, 6), new Kostka(1, 6));
            var menu = new Menu();
            menu.Polozky = new List<PolozkaMenu>();
            menu.Polozky.Add(new PolozkaMenu() { Identifikator = 1, Text = "Start" });
            menu.Polozky.Add(new PolozkaMenu() { Identifikator = 2, Text = "Nastav" });
            menu.Polozky.Add(new PolozkaMenu() { Identifikator = 3, Text = "Konec" });
            //menu.DisplayMenu();
            //menu.PosunDolu();
            //menu.DisplayMenu();
            //menu.PosunDolu();
            //menu.DisplayMenu();
            //menu.PosunDolu();
            //menu.DisplayMenu();
            menu.Konzole();
        }
    }
}
