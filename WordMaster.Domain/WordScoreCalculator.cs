namespace WordMaster.Domain;

public class WordScoreCalculator
{
    private int LongWordBonus = 5;
    private int ContainsEBonus = 2;
    public int CalculateScore(string word)
    {

        if (word == null)
        {
            throw new ArgumentNullException(nameof(word));
        }

        word = word.Trim();
        
        int letters = word.Length;
        int score = letters;

        if (letters > 5)
        {
            score += LongWordBonus;
        }

        if (word.Contains('e',  StringComparison.OrdinalIgnoreCase))
        {
            score += ContainsEBonus;
        }

        return score;
    }
}