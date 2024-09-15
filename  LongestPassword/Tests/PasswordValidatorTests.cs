using LongestPassword;

namespace Tests;

public class PasswordValidatorTests
{
    [Test]
    public void Test1()
    {
        var result = PasswordValidator.GetLongestValidLength("test 5 a0A pass007 ?xy1");
        
        Assert.AreEqual(7, result);
    }
    
    [Test]
    public void Test2()
    {
        var result = PasswordValidator.GetLongestValidLength("22 33fgfgdsdfsdfsdfsfsdf 13sfdf12sdfs1 13sfdf12sdfs1!");
        
        Assert.AreEqual(13, result);
    }
    
    [Test]
    public void Test3()
    {
        var result = PasswordValidator.GetLongestValidLength("22 33fgfgdsdfsdfsdfsfsdf 13sfdf12sdfs13 13sfdf12sdfs1!");
        
        Assert.AreEqual(-1, result);
    }
}