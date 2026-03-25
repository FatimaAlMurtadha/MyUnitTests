namespace WordMaster.Tests;

using global::WordMaster.Domain;
using Xunit;

public class PalindromeWordsTests
{
    [Fact]
    public void PalindromeWords_ShouldReturnTrue()
    {
        PlindromeChecker checker = new PlindromeChecker();
        bool result = checker.IsPlindrome("level");
        
        Assert.True(result);
    }

    [Fact]
    public void PalindromeWords_ShouldReturnFalse()
    {
        PlindromeChecker checker = new PlindromeChecker();

        bool result = checker.IsPlindrome("hello");
        
        Assert.False(result);
    }
}