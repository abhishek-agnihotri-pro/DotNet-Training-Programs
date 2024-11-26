using Calculator_DLL_Project;

namespace Test_DLL;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test,Order(1)]
    [TestCase(15,35,50)]
    [TestCase(10,45,55)]
    [TestCase(20,50,60)]
    public void Test_AddMethod(int n1, int n2, int expected)
    {
        Calculator obj = new Calculator();
        int res = obj.Add(n1, n2);
        Assert.AreEqual(expected,res);
    }

    [Test,Order(2)]
    [TestCase(30,10,20)]
    [TestCase(45,10,35)]
    [TestCase(20,50,60)]
    public void Test_SubMethod(int n1, int n2, int expected)
    {
        Calculator obj = new Calculator();
        int res = obj.Sub(n1, n2);
        Assert.AreEqual(expected,res);
    }

}