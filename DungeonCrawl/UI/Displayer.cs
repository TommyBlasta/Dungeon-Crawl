using System;

namespace DungeonCrawl.UI
{
    class Displayer
    {
        const string Oddelovac = "--------------------------------";
        private GameController GameController { get; set; }
        public Displayer(GameController gameController)
        {
            GameController = gameController;
            GameController.GameStateChanged += DisplayChange;
        }
        private void DisplayMenu()
        {
            foreach (var polozka in GameController.SoucasneMenu.Polozky)
            {
                if (GameController.SoucasneMenu.Polozky.IndexOf(polozka) == GameController.SoucasneMenu.IndexVybranePolozky)
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

        internal void DisplayChange(object sender, EventArgs e)
        {
            ToScreen();
            return;
        }

        private void DisplayHero()
        {
            Console.WriteLine($"Hrdina:{GameController.HlavniHrdina.Jmeno} - HP:{GameController.HlavniHrdina.Zdravi} - INT:{GameController.HlavniHrdina.IntelektKostka} - STR:{GameController.HlavniHrdina.SilovaKostka} - DEX: {GameController.HlavniHrdina.ObratnostKostka}");
            Console.WriteLine("");
        }
        private void DisplayMainText()
        {
            foreach(string s in GameController.SoucasnyText)
            {
                Console.WriteLine(s);
            }
        }
        public void ToScreen()
        {
            Console.Clear();
            DisplayMainText();
            Console.WriteLine(Oddelovac);
            DisplayMenu();
            Console.WriteLine(Oddelovac);
            DisplayHero();
        }

    }
}
