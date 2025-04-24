using Xunit;
using XUnitPractice.v2.Extensions;

namespace XUnitPractice.v2.SimpleAssert;

public class AssertionsExamples
{
    [Fact]
    public void EnsureAlesness()
    {
        const string firstName = "Ales";
        
        var person1 = new Person("Ales", "Happy");
        var person2 = new Person("Alex", "Sad");

        Assert.Equal(firstName, person1.FirstName);
        Assert.NotEqual(firstName, person2.FirstName);
    }

    [Fact]
    public void ShouldBeTrue() => true.ShouldBeTrue();
    
    [Fact]
    public void ShouldBeFalse() => false.ShouldBeFalse();
    
    [Fact]
    public void ShouldBeTrueWithMessage()
    {
        var ex = Record.Exception(() => false.ShouldBeTrue("should be true"));

        Assert.NotNull(ex);
        Assert.StartsWith("should be true", ex.Message);
    }

    [Fact]
    public void ShouldBeFalseWithMessage()
    {
        var ex = Record.Exception(() => true.ShouldBeFalse("should be false"));

        Assert.NotNull(ex);
        Assert.StartsWith("should be false", ex.Message);
    }
    
    //more examples https://github.com/xunit/samples.xunit
}