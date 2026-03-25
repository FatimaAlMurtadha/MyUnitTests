namespace WordMaster.Domain;

public class PlindromeWordsChecker
{
    public bool IsPlindrome(string word)
    {
        return word.SequenceEqual(word.Reverse());
    }
}