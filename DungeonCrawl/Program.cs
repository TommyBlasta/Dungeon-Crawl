using DungeonCrawl.Controls;
using DungeonCrawl.UI;
using System;
using System.Collections.Generic;

namespace DungeonCrawl
{
    class Program
    {
        static void Main(string[] args)
        {
            //tvorba menu
            var menu = new Menu();
            menu.Polozky = new List<PolozkaMenu>();
            menu.Polozky.Add(new PolozkaMenu()
            {
                Identifikator = 1,
                ObjektPolozky = new Predmet()
                {
                    ID = 1,
                    Nazev = "Dřevěné dveře",
                    Popis = "Masivní dveře z tmavého dřeva. Jsou osazeny mosaznou klikou, za kterou když vezmeš, tak se dveře ani nehnou. Jsou zamčené.",
                    ItemFlags = Enums.ItemFlags.TextVypis
                }
            });
            menu.Polozky.Add(new PolozkaMenu() 
            { 
                Identifikator = 2, 
                ObjektPolozky = new Predmet()
                {
                    ID = 2,
                    Nazev = "Meč",
                    Popis = "Na steně visící meč, který by ti padnul akorát do ruky.",
                    ItemFlags = Enums.ItemFlags.Sebratelny | Enums.ItemFlags.TextVypis
                }
            });
            menu.Polozky.Add(new PolozkaMenu() 
            { 
                Identifikator = 3, 
                ObjektPolozky = new Predmet()
                {
                    ID = 3,
                    Nazev = "Skříň",
                    Popis = "V rohu místnosti stojí velká skříň. Co by v ní tak mohlo být?",
                    ItemFlags = Enums.ItemFlags.TextVypis
                }
            });
            //
            //tvorba hrdiny
            var hrdina = new Hrdina()
            {
                Jmeno = "tester",
                Zdravi = 100,
                SilovaKostka = new Kostka(1, 10),
                ObratnostKostka = new Kostka(1, 10),
                IntelektKostka = new Kostka(1, 10)
            };
            //
            //inicializace controlleru
            var gameController = new GameController(hrdina, menu);
            //
            //inicializace displayeru
            var mainDisplayer = new Displayer(gameController);
            //start gaem
            gameController.GameRunning = true;
            //Game
            while(gameController.GameRunning)
            {
                gameController.ZpracujPrikaz();
            }
        }
    }
}
