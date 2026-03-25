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
    
    /*
     *  Edge Cases
     */
    // 1. Empty string
    [Fact]
    public void CalculateScore_emptyWord_ReturnsZero()
    {
        // Arrange
        string word = "";
        // Act
        int score = calculator.CalculateScore(word);
        // Assert
        Assert.Equal(0, score);
    }
    
    // 2. Null
    [Fact]
    public void CalculateScore_NullWord_ThrowException()
    {
        // Act and Assert
        Assert.Throws<ArgumentNullException>(() => calculator.CalculateScore(null));
    }
    
    // 3. The bonus boundary
    [Fact]
    public void CalculateScore_WordWithFiveLetters_ShouldNotHaveBonus()
    {
        // Act
        int score = calculator.CalculateScore("apple");
        // Assert
        Assert.Equal(5, score);
    }
    
    // 4. The words more than 5 letters
    [Fact]
    public void CalculateScore_WordWithSixLetters_ShouldAddBonus()
    {
        // Act
        int score = calculator.CalculateScore("banana");
        // Assert
        Assert.Equal(11, score); // 6 + 5
    }
    // 5. UpperCase Words
    [Fact]
    public void CalculateScore_WordWithUppercase_ShouldCountLettersCorrectly()
    {
        // Act
        int score = calculator.CalculateScore("Cat");
        // Assert
        Assert.Equal(3, score);
    }
    
    // 6. Empty spaces
    [Fact]
    public void CalculateScore_WordWithSpaces_ShouldIgnoreSpacesCorrectly()
    {
        // Act
        int score = calculator.CalculateScore("  cat ");
        // Assert
        Assert.Equal(3, score);
    }
    
    
    /*
     *  New TDD
     */
    [Fact]
    public void CalculateScore_WordContainingE_AddsTwoBonusPoints()
    {
        // Arrange
        string word = "tree";
        // Act 
        int score = calculator.CalculateScore(word);
        // Assert
        Assert.Equal(6, score); // 4 +2 
    }
}