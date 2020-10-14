using DungeonCrawl.Interfaces;
using System;
using System.Collections.Generic;

namespace DungeonCrawl
{
    class Menu : IDisplayMenu
    {
        private int indexVybranePolozky;

        public List<PolozkaMenu> Polozky { get; set; }
        public int IndexVybranePolozky 
        { 
            get => indexVybranePolozky;
            set
            {
                int novaHodnota = value;
                if(novaHodnota >= Polozky.Count)
                {
                    indexVybranePolozky = 0;
                } 
                else if(novaHodnota < 0)
                {
                    indexVybranePolozky = Polozky.Count - 1;
                }
                else
                {
                    indexVybranePolozky = novaHodnota;
                }
            }
        }
        public void PosunDolu()
        {
            IndexVybranePolozky++;
        }
        public void PosunNahoru()
        {
            IndexVybranePolozky--;
        }

        public void DisplayMenu()
        {
            foreach (var polozka in Polozky)
            {
                if (Polozky.IndexOf(polozka) == IndexVybranePolozky)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(polozka.Text);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(polozka.Text);
                }
            }
        }
        public void Konzole()
        {
            DisplayMenu();
            while (true)
            {
                var stisknutaKlavesa = Console.ReadKey();

                switch (stisknutaKlavesa.Key)
                {
                    case ConsoleKey.DownArrow:
                        { 
                            Console.Clear();
                            PosunDolu();
                            DisplayMenu();
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            Console.Clear();
                            PosunNahoru();
                            DisplayMenu();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            break;
                        }
                

                }
            }
        }
    }
}
