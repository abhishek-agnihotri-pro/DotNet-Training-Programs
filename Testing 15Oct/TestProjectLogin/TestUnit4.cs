using NuGet.Frameworks;

namespace TestProjectLogin
{
    [TestFixture]
    public class UnitTest4{
        [TestCase]
        public void TestMethod4(){
            int quantity = 100;
            decimal price = 2.5m;
            decimal totalexpected = 251;
            decimal actual = quantity*price;
            Assert.AreEqual(totalexpected,actual);
        }
    }
}