using Xunit;

namespace XUnitPractice.v2.Extensions;

public static class BooleanExtensions
{
    public static void ShouldBeTrue(this bool value) => Assert.True(value);
    
    public static void ShouldBeTrue(this bool value, string userMessage) => Assert.True(value, userMessage);

    public static void ShouldBeFalse(this bool value) => Assert.False(value);
    
    public static void ShouldBeFalse(this bool value, string userMessage) => Assert.False(value, userMessage);
}