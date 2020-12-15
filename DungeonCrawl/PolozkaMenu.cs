using DungeonCrawl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl
{
    class PolozkaMenu
    {
        private string text;
        private int identifikator;
        public string Text { get => ObjektPolozky.Nazev; }
        public int Identifikator { get => identifikator; set => identifikator = value; }
        public IInterakce ObjektPolozky { get; set; }
    }
}
