namespace TestProjectLogin
{
    [TestFixture]
    public class UnitTest2{
        [TestCase]
        public void TestMethod1(){
            List<string> first = new List<string>();
            first.Add("a");
            // first.Add("b");
            // first.Add("c");

            List<string> second = new List<string>();
            second.Add("a");
            // second.Add("2");
            // second.Add("3");
            CollectionAssert.DoesNotContain(first,"x");
            CollectionAssert.AreEqual(first,second);
        }
    }
}