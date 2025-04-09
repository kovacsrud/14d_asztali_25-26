using KRHash;

namespace HashTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami szöveg", "22e67b691bcc1bb1c806364fb660294e")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        [TestCase("Valami másmilyen szöveg", "d5a8277092d8e65acdbfb31f6cc5b13a")]
        public void MD5Test(string szoveg,string elvart)
        {
            CreateHash hash = new CreateHash();
            var szovegHash = hash.MakeHash(HashType.MD5,szoveg);
            Assert.AreEqual(elvart, szovegHash);
        }
    }
}