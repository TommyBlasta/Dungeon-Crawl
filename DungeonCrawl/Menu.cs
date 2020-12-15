using DungeonCrawl.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DungeonCrawl
{
    class Menu : IDisplayMenu, INotifyPropertyChanged
    {
        private int indexVybranePolozky;
        private PolozkaMenu soucasnaPolozka;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string changedItem)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(changedItem));
        }
        public List<PolozkaMenu> Polozky { get; set; }
        public PolozkaMenu SoucasnaPolozka 
        {
            get => Polozky[indexVybranePolozky]; 
            set => soucasnaPolozka = value; 
        }
        public int IndexVybranePolozky
        {
            get => indexVybranePolozky;
            set
            {
                int novaHodnota = value;
                if (novaHodnota >= Polozky.Count)
                {
                    indexVybranePolozky = 0;
                }
                else if (novaHodnota < 0)
                {
                    indexVybranePolozky = Polozky.Count - 1;
                }
                else
                {
                    indexVybranePolozky = novaHodnota;
                }
                NotifyPropertyChanged("IndexVybranePolozky");
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
        public override string ToString()
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
            return base.ToString();
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
