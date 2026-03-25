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
        ScoreCalculator calculator = new ScoreCalculator();
        int score = calculator.CalculateScore("cat");

        Assert.Equal(3, score);
    }
}