using System;
using System.Runtime.Serialization;

namespace DungeonCrawl
{
    [DataContract(Name = "Kostka")]
    public class Kostka
    {
        private Random random;
        [DataMember]
        private int DolniHranice { get; set; }
        [DataMember]
        private int HorniHranice { get; set; }
        public Kostka()
        {

        }
        public Kostka(int dolniHranice, int horniHranice)
        {
            random = new Random();
            DolniHranice = dolniHranice;
            HorniHranice = horniHranice;
        }
        /// <summary>
        /// změní horní a dolní hranici kostky
        /// </summary>
        /// <param name="zmenaDolni"> přičte hodnotu k dolní hranici kostky </param>
        /// <param name="zmenaHorni"> přičte hodnotu k horní hranici kostky </param>
        public void Zmen(int zmenaDolni, int zmenaHorni)
        {
            DolniHranice += zmenaDolni;
            HorniHranice += zmenaHorni;
            if (HorniHranice < DolniHranice)
            {
                HorniHranice = DolniHranice;
            }
        }
        /// <summary>
        /// hod kostkou
        /// </summary>
        /// <returns> vrátí hodnotu hodu </returns>
        public int Hod()
        {
            return random.Next(DolniHranice, HorniHranice);
        }
        public override string ToString()
        {
            return "Kostka: " + DolniHranice + "-" + HorniHranice;
        }
        public KostkaSerial ToSerial()
        {
            return new KostkaSerial() { DolniHranice = this.DolniHranice, HorniHranice = this.HorniHranice };
        }

    }
}
