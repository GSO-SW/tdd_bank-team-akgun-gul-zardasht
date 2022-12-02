using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public Konto(int guthaben)
        {
            this.guthaben = guthaben;
            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Guthaben darf nicht im negativem Bereich liegen.");
            }
        }

        public void Einzahlen(int betrag)
        {
            if (betrag > 0)
            {
                guthaben += betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Betrag darf nicht negativ sein.");
            }
        }

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}