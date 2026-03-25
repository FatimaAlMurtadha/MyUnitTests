namespace WordMaster.Tests;

using global::WordMaster.Domain;
using Xunit;

public class PalindromeWordsTests
{
    [Fact]
    public void PalindromeWords_ShouldReturnTrue()
    {
        PlindromeWordsChecker checker = new PlindromeWordsChecker();
        bool result = checker.IsPlindrome("level");
        
        Assert.True(result);
    }

    [Fact]
    public void PalindromeWords_ShouldReturnFalse()
    {
        PlindromeWordsChecker checker = new PlindromeWordsChecker();

        bool result = checker.IsPlindrome("hello");
        
        Assert.False(result);
    }
}