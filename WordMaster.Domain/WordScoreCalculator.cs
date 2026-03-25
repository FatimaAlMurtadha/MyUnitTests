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
        
        int letters = word.Length;
        int score = letters;
        bool hasBonus = letters > 5;

        if (hasBonus)
        {
            score += 5;
        }

        return score;
    }
}