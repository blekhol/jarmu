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


        public void Gyorsit(int novekedes)
        {
            AktualisSebesseg += novekedes;
            Console.WriteLine($"A {marka} {modell} gyorsul {novekedes} km/h-val. Új sebesség: {aktualisSebesseg} km/h.");
        }

        public void Fekez(int csokkentes)
        {
            AktualisSebesseg -= csokkentes;
            Console.WriteLine($"A {marka} {modell} fékez {csokkentes} km/h-val. Új sebesség: {aktualisSebesseg} km/h.");
        }

        public override string ToString()
        {
            return $"Sportautó adatai:\nMárka: {marka}\nModell: {modell}\nÉvjárat: {evjarat}\nMax Sebesség: {maxSebesseg} km/h\nAktuális Sebesség: {aktualisSebesseg} km/h";
        }
    }
}
