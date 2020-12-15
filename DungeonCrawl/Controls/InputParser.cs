using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawl.Controls
{
    class InputParser
    {
        public ConsoleKeyInfo Parse()
        {
            return Console.ReadKey();
        }
    }
}
