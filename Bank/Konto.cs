using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        static int kontoNr;

        public int KontoNr
        {
            get { return kontoNr; }
        }

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
        }

        public void Einzahlen(int betrag)
        {
            if (betrag >= 0)
            {
                guthaben += betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Betrag darf nicht unter 0 sein.");
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
