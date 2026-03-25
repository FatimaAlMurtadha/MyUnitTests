namespace WordMaster.Tests;

using global::WordMaster.Domain;
using Xunit;

public class WordScoreCalculatorTests // class
{
    // New : 
    // use a constructor to create a calculator
    private readonly WordScoreCalculator calculator; // init the constractor's variable
    public WordScoreCalculatorTests()  // a constructor
    {
        calculator = new WordScoreCalculator();
    }
    
    /*
     * The second feature // Score system
     * // 1 point for every letter and Bonus for words long words +5
     */

    // 1. a 3 letters word
    [Fact]
    public void CalculateScore_ShortWord_ReturnsWordLength() // fix naming
    {
        // Arrange
        string word = "cat";
        
        // Act
        int score = calculator.CalculateScore(word);

        // Assert
        Assert.Equal(3, score);
    }
    
    // 2. longer than 5 letters
    [Fact]
    public void CalculateScore_LongWord_AddBonus()
    {
        // Arrange
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
    public void CalculateScore_Word_ReturnsCorrectScore(string word, int expectedScore)
    {
        // Act
        int score = calculator.CalculateScore(word);
        Assert.Equal(expectedScore, score);
    }
}