using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl
{
    public class Mistnost
    {
        public List<Predmet> PredmetyVMistnosti { get; set; }
        public List<Nepritel> NeprateleVMistnosti { get; set; }
        public List<Mistnost> NavazujiciMistnosti { get; set; }

    }
}
