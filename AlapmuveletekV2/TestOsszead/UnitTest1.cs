using AlapmuveletekV2;

namespace TestOsszead
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource("GetOsszeadasAdatok")]
        public void OsszeadasTest(double a,double b,double elvart)
        {
            //Arrange
            Alapmuveletek alapmuveletek = new Alapmuveletek();

            //Act
            var eredmeny = alapmuveletek.Osszead(a,b);

            //Assert
            Assert.AreEqual(elvart,eredmeny);
        }

        [Test]
        [TestCaseSource("GetOsztasAdatok")]
        public void OsztasTest(double a,double b,double elvart)
        {
            Alapmuveletek alapmuveletek=new Alapmuveletek();
            var eredmeny=alapmuveletek.Oszt(a,b);
            Assert.AreEqual(elvart,eredmeny,0.000001);
        }

        public static IEnumerable<double[]> GetOsszeadasAdatok()
        {
            var sorok = File.ReadAllLines("tesztesetek_osszeadas.csv");
            for (int i = 0; i < sorok.Length; i++)
            {
                var adatok = sorok[i].Split(';');
                double a=Convert.ToDouble(adatok[0]);
                double b=Convert.ToDouble(adatok[1]);
                double elvart=Convert.ToDouble(adatok[2]);

                yield return new[] { a, b, elvart };
            }
        }

        public static IEnumerable<double[]> GetOsztasAdatok()
        {
            var sorok = File.ReadAllLines("tesztesetek_osztas.csv");
            for (int i = 0; i < sorok.Length; i++)
            {
                var adatok = sorok[i].Split(';');
                double a = Convert.ToDouble(adatok[0]);
                double b = Convert.ToDouble(adatok[1]);
                double elvart = Convert.ToDouble(adatok[2]);

                yield return new[] { a, b, elvart };
            }
        }

    }
}