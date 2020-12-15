using DungeonCrawl.Controls;
using DungeonCrawl.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DungeonCrawl
{
    /// <summary>
    /// Ovlada hru, dungeon, mistnosti, pribeh a kontrolu pruchodu.
    /// </summary>
    class GameController
    {
        private Hrdina hlavniHrdina;
        private Menu soucasneMenu;
        private string[] soucasnyText;
        private Dungeon activeDungeon;

        public bool GameRunning { get; set; }
        public Dungeon ActiveDungeon { get => activeDungeon; set => activeDungeon = value; }
        public Hrdina HlavniHrdina
        {
            get => hlavniHrdina;
            set
            {
                hlavniHrdina = value;
                NotifyGameStateChanged();
            }
        }
        public Menu SoucasneMenu
        {
            get => soucasneMenu;
            set
            {
                soucasneMenu = value;
                NotifyGameStateChanged();
            }
        }
        public Mistnost SoucasnaMistnost { get; set; }
        public string[] SoucasnyText
        {
            get => soucasnyText;
            set
            {
                soucasnyText = value;
                NotifyGameStateChanged();
            }
        }
        public event EventHandler GameStateChanged;
        private void NotifyGameStateChanged()
        {
            GameStateChanged?.Invoke(this, new EventArgs());
        }
        public GameController(Hrdina hlavniHrdina, Menu prvotniMenu)
        {
            soucasnyText = new string[1];
            HlavniHrdina = hlavniHrdina;
            SoucasneMenu = prvotniMenu;
            HlavniHrdina.PropertyChanged += GameObjectsPropertyChanged;
            SoucasneMenu.PropertyChanged += GameObjectsPropertyChanged;
        }

        private void GameObjectsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyGameStateChanged();
        }

        public void ZpracujPrikaz()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        SoucasneMenu.PosunNahoru();
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        SoucasneMenu.PosunDolu();
                        break;
                    }
                case ConsoleKey.Enter:
                    {
                        var prikaz = SoucasneMenu.SoucasnaPolozka.ObjektPolozky.Interakce();
                        ProvedPrikaz(prikaz);
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        GameRunning = false;
                        break;
                    }
            }

        }
        private void ProvedPrikaz(ControllerCommand prikazKProvedeni)
        {
            switch (prikazKProvedeni.AkceKProvedeni)
            {
                case Enums.AkceController.ProzkoumejPredmet:
                    {
                        SoucasnyText[0] = prikazKProvedeni.TextInterakce;
                        NotifyGameStateChanged();
                        break;
                    }
            }
        }

    }
}
