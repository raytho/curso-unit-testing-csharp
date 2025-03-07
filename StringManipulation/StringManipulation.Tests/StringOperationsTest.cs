using Microsoft.Extensions.Logging;
using Moq;

namespace StringManipulation.Tests;

public class StringOperationsTest
{
    [Fact(Skip = "Not implemented")]
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

    [Fact]
    public void QuantintyInWordsTest()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.QuantintyInWords("cat", 10);
        
        // Assert
        Assert.StartsWith("ten", result);
        Assert.Contains("cat", result);
    }

    [Fact]
    public void GetStringLengthTest()
    {
        var strOperations = new StringOperations();
        Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
    }

    [Fact]
    public void TruncateStringTestShouldReturnException()
    {
        var strOperations = new StringOperations();
        Assert.ThrowsAny<ArgumentOutOfRangeException>(() => strOperations.TruncateString("Hello", 0));
    }

    [Theory]
    [InlineData("V", 5)]
    [InlineData("III", 3)]
    public void FromRomanToIntTest(string romanNumber, int expectedResult)
    {
        var strOperations = new StringOperations();
        var result = strOperations.FromRomanToNumber(romanNumber);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData("oro", true)]
    [InlineData("hello", false)]
    public void IsPalindromeParamTestIsTrue(string word, bool isPalindrome)
    {
        var strOperations = new StringOperations();
        var result = strOperations.IsPalindrome(word);
        Assert.Equal(isPalindrome, result);
    }

    [Fact]
    public void CountOccurrencesTest()
    {
        var mockLogger = new Mock<ILogger<StringOperations>>();
        var strOperations = new StringOperations(mockLogger.Object);

        var result = strOperations.CountOccurrences("Hello platzi", 'l');
        Assert.Equal(3, result);
    }
}