namespace BinaryStringEvaluator.Tests;

public class BinaryStringEvaluatorTests
{
    [Theory]
    [InlineData("1100", true)]   // Equal number of 0's and 1's, satisfies prefix condition
    [InlineData("1001", false)]  // Fails prefix condition (more 0's than 1's in prefix)
    [InlineData("1010", true)]   // Equal number of 0's and 1's, satisfies prefix condition
    [InlineData("1111", false)]  // Only 1's, no 0's
    [InlineData("0000", false)]  // Only 0's, no 1's
    [InlineData("", true)]       // Empty string
    public void IsGoodBinaryString_ValidInputs_ReturnsExpectedResult(string binaryString, bool expected)
    {
        // Act
        var result = BinaryStringEvaluator.IsGoodBinaryString(binaryString);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IsGoodBinaryString_InvalidCharacters_ThrowsArgumentException()
    {
        // Arrange
        string binaryString = "101a01";

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => BinaryStringEvaluator.IsGoodBinaryString(binaryString));
        Assert.Equal("Input string must contain only '0' or '1'.", exception.Message);
    }
}