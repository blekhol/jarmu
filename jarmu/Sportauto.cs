using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    internal class Sportauto
    {
        // Adattagok
        private string marka;
        private string modell;
        private int evjarat;
        private int maxSebesseg;
        private int aktualisSebesseg;

        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Evjarat { get => evjarat; set => evjarat = value; }
        public int MaxSebesseg { get => maxSebesseg; set => maxSebesseg = value; }
        public int AktualisSebesseg { get => aktualisSebesseg; set => aktualisSebesseg = value; }

        // Konstruktorok
        public Sportauto()
        {
            marka = "Ismeretlen";
            modell = "Ismeretlen";
            evjarat = 2000;
            maxSebesseg = 200;
            aktualisSebesseg = 0;
        }

        public Sportauto(string marka, string modell, int evjarat, int maxSebesseg)
        {
            this.marka = marka;
            this.modell = modell;
            this.evjarat = evjarat;
            this.maxSebesseg = maxSebesseg;
            this.aktualisSebesseg = 0;
        }


        
    }
}
