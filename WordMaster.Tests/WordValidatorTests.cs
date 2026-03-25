namespace WordMaster.Tests;

using global::WordMaster.Domain;
using Xunit;

public class WordValidateTests
{
  
  /*
   * The first feature  // the word length
   * */
   
  // 1. less than 3 letters  ** FAILD **
  [Fact]
  public void Word_WithLessThanThreeLetters_ShouldBeInvalid()
  {
    // Arrange
    WordValidator validator = new WordValidator();

    //Act
    bool result = validator.IsValidLength("hi");

    // Assert
    Assert.False(result);
  }

  // Here comes more rules

  // 2. The word should also be valid 3 letters ** PASS **

  [Fact]
  public void Word_WithThreeLetters_ShouldBeValid()
  {
    // arrange
    WordValidator validator = new WordValidator();

    // Act
    bool result = validator.IsValidLength("cat");

    // Assert
    Assert.True(result);
  }

  // 3. A long word more than 3 letters ** PASS **
  [Fact]
  public void Word_WithManyLetters_ShouldBeValid()
  {
    WordValidator validator = new WordValidator();

    bool result = validator.IsValidLength("elephant");

    Assert.True(result);
  }

  // 4. an empty word ** FAILD **
  [Fact]
  public void EmptyWord_ShouldBeInvalid()
  {
    WordValidator validator = new WordValidator();

    bool result = validator.IsValidLength("");

    Assert.False(result);
  }
  
  /*
   * The second feature // Score system
   * // 1 point for every letter and Bonus for words long words +5 
   */

  // 1. a 3 letters word
  [Fact]
  public void ShortWord_ShouldReturnLengthScore()
  {
    ScoreCalculator calculator = new ScoreCalculator();
    int score = calculator.CalculateScore("cat");
    
    Assert.Equal(3, score);
  }
}


