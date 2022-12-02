using System;

namespace Bank
{
    public class Konto
    {

        private int guthaben;
        static int kontonNr;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public int KontoNr
        {
            get
            {
                return kontonNr;
            }
        }


        public Konto(int guthaben)
        {
            this.guthaben = guthaben;
<<<<<<< HEAD

=======
            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Guthaben darf nicht im negativem Bereich liegen.");
            }
>>>>>>> Berkant_TDD_Test
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