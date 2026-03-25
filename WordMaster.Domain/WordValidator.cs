namespace WordMaster.Domain;

public class WordValidator
{
  // validate that the word has at least 3 letters

  public bool IsValidLength(string word)
  {
    return word.Length >= 3;
  }

  // *
}