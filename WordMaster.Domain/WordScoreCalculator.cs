namespace WordMaster.Domain;

public class WordScoreCalculator
{
    public int CalculateScore(string word)
    {
        int score = word.Length;

        if (word.Length <5)
        {
            score += 5;
            
        }

        return score;
        
    }
}