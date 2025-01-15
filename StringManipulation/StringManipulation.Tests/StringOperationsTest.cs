namespace StringManipulation.Tests;

public class StringOperationsTest
{
    [Fact]
    public void ConcatenateStringsTest()
    {
        var strOperations = new StringOperations();
        var result = strOperations.ConcatenateStrings("Hello", "World");
        Assert.Equal("Hello World", result);
    }
}