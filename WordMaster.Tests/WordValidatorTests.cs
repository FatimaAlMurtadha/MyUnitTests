namespace WordMaster.WordMaster.Tests;

using global::WordMaster.Domain;
using Xunit;

public class WordValidateTests
{
  // 
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
}


