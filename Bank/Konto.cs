﻿using System;

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
