namespace Test_Collection_Asert;

public class Tests
{
    CollectionDemo obj = null;
    [SetUp]
    public void Setup()
    {
        obj = new CollectionDemo();
    }
    [TearDown]
    public void CloseUp(){
        obj = null;
    }

    public void GetNames_Unique(){
        List<string> names = obj.GetName();
        CollectionAssert.AllItemsAreUnique(names,"Names are not Unique");
    }
    [Test]
    public void GetName_Contains_Null(){
        List<string> names = obj.GetName();
        CollectionAssert.AllItemsAreNotNull(names,"Collections contins null values");
    }
    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}