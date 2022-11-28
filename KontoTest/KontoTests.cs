using Bank;

namespace KontoTest
{
    [TestClass]
    public class KontoTests
    {


        [TestMethod]
        public void Einzahlen()
        {
            //Arrange
            Konto k1 = new Konto(100);

            //Act
            int guthaben = 20;
            guthaben = guthaben + k1.Guthaben;
            k1.Einzahlen(20);
            //Assert
            Assert.AreEqual(k1.Guthaben, guthaben);
        }
    }
}