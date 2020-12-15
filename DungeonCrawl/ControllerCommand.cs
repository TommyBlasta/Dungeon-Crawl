using DungeonCrawl.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl
{
    public class ControllerCommand
    {
        public string TextInterakce { get; set; }
        public Dictionary<int,object> ObjektyKInterakci { get; set; }
        public AkceController AkceKProvedeni { get; set; }
    }
}
