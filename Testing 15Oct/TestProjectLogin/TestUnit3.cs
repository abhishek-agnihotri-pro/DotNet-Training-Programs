namespace TestProjectLogin
{
    [TestFixture]
    public class UnitTest3
    {
        [TestCase]
        public void TestMethod1()
        {
            List<string> str1 = new List<string>();
            str1.Add(null);
            str1.Add("b");
            str1.Add("c");

            CollectionAssert.AllItemsAreNotNull(str1);
        }
    }
}