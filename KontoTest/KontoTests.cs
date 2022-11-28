using Bank;

namespace BankTests
{
    [TestClass]
    public class KontoTests
    {

        [TestMethod]
        public void Konto_Positiv_StartwertWirdInGuthabenEingetragen()
        {
            //Arrange
            int startwert = 50;
            
            //Act
            Konto k1 = new Konto(startwert);

            //Assert
            Assert.AreEqual(startwert, k1.Guthaben);
        }


        //Hier sind wir stehen geblieben
        [TestMethod]
        public void Konto_Negativ_StartwertWirdInGuthabenEingetragen()
        {
            //Arrange
            int startwert = -50;

            //Act
            Konto k1 = new Konto(startwert);

            //Assert
            Assert.AreEqual(startwert, k1.Guthaben);
        }


        [TestMethod]
        public void Einzahlen_SteigertGuthaben()
        {
            //Arrange
            int startguthaben = 100;
            Konto k1 = new Konto(startguthaben);
            int einzahlungsbetrag = 20;

            int guthaben_soll = startguthaben + einzahlungsbetrag;


            //Act
            k1.Einzahlen(einzahlungsbetrag);
            
            //Assert
            Assert.AreEqual(guthaben_soll, k1.Guthaben);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Einzahlen_NegativerBetrag()
        {
            //Arrange
            int startguthaben = 100;
            Konto k1 = new Konto(startguthaben);
            int einzahlungsbetrag = -1;

            int guthaben_soll = startguthaben + einzahlungsbetrag;


            //Act
            k1.Einzahlen(einzahlungsbetrag);

        }
    }
}