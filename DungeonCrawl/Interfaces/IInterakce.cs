using DungeonCrawl.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl.Interfaces
{
    interface IInterakce 
    {
        public ControllerCommand Interakce();
        public string Nazev { get; set; }
    }
}
