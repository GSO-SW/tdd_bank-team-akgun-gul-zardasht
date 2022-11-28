using Bank;

namespace BankTests
{
    [TestClass]
    public class KontoTests
    {
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