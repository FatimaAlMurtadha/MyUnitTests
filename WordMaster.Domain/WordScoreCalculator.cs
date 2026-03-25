namespace WordMaster.Domain;

public class WordScoreCalculator
{
    public int CalculateScore(string word)
    {

        if (word == null)
        {
            throw new ArgumentNullException(nameof(word));
        }

        word = word.Trim();
        
        if (word.Length == 0)
        {
            return 0;
        }

        int score = word.Length;

        if (word.Length > 5)
        {
            score += 5;

        }

        return score;
    }
}