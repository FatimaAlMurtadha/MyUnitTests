namespace WordMaster.Tests;

using global::WordMaster.Domain;
using Xunit;

public class WordScoreCalculatorTests
{
    /*
     * The second feature // Score system
     * // 1 point for every letter and Bonus for words long words +5
     */

    // 1. a 3 letters word
    [Fact]
    public void ShortWord_ShouldReturnLengthScore()
    {
        WordScoreCalculator calculator = new WordScoreCalculator();
        int score = calculator.CalculateScore("cat");

        Assert.Equal(3, score);
    }
    
    // 2. longer than 5 letters
    [Fact]
    public void LongWord_ShouldAddBonus()
    {
        // Arrange
        WordScoreCalculator calculator = new WordScoreCalculator();
        string word = "planet";
        // Act
        int score = calculator.CalculateScore(word);
        
        // Assert
        Assert.Equal(11, score);
    }
    
    // Theory to handle score calculation
    [Theory]
    [InlineData("cat", 3)]
    [InlineData("tree", 4)]
    [InlineData("planet", 11)]
    [InlineData("elephant", 13)]
    public void LongWord_ShouldReturnCorrectScore(string word, int expectedScore)
    {
        WordScoreCalculator calculator = new WordScoreCalculator();
        int score = calculator.CalculateScore(word);
        Assert.Equal(expectedScore, score);
    }
}