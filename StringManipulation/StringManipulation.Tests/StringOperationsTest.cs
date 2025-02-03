namespace StringManipulation.Tests;

public class StringOperationsTest
{
    [Fact]
    public void ConcatenateStringsTest()
    {
        // Arrange
        var strOperations = new StringOperations();
        
        // Act
        var result = strOperations.ConcatenateStrings("Hello", "World");
        
        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void IsPalindromeTestIsTrue()
    {
        // Arrange
        var strOperations = new StringOperations();
        
        // Act
        var result = strOperations.IsPalindrome("ama");
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindromeTestIsFalse()
    {
        var strOperations = new StringOperations();
        var result = strOperations.IsPalindrome("hello");
        Assert.False(result);
    }

    [Fact]
    public void RemoveWhiteSpaceTest()
    {
        var strOperations = new StringOperations();
        var result = strOperations.RemoveWhitespace(" Hola, esto es una prueba ");
        Assert.DoesNotContain(" ", result);
    }
    
}