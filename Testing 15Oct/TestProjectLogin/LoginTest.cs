using System.Runtime.Remoting;
using LibraryforCollectionTest;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TestProjectLogin;


[TestFixture]
public class LoginTest
{
    LoginClass obj;

    [SetUp]
    public void SetUp()
    {
        obj = new LoginClass();
    }

    public void remove()
    {

    }
    [Test]
    public void LoginTestForEmpty()
    {
        string expected = "user or password is null";
        string actual = null;
        actual = obj.Login("", "");
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void LoginTestForCorrectLogin()
    {
        string expected = "Welcome Admin";
        string actual = obj.Login("Admin","admin");
        
        Assert.AreEqual(expected, actual);
        Assert.That(actual,Is.EqualTo("Welcome Admin"));
    }
    [Test]
    public void LoginTestForIncorrectLogin()
    {
        string expected = "Invalid User or Password";
        string actual = obj.Login("admin","admin");
        
        Assert.AreEqual(expected, actual);
        // Assert.That(actual,Is.EqualTo("Welcome Admin"));
    }
}