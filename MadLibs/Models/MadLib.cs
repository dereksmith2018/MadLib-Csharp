namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _verb;
    private string _pronoun;
    private string _noun;
    private string _adverb;
    private string _adjective;

    public string GetVerb()
    {
      return _verb;
    }

    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
    }
    public string GetPronoun()
    {
      return _pronoun;
    }
    public void SetPronoun(string newPronoun)
    {
      _pronoun = newPronoun;
    }
    public string GetNoun()
    {
      return _noun;
    }
    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }
    public string GetAdverb()
    {
      return _adverb;
    }
    public void SetAdverb(string newAdverb)
    {
      _adverb = newAdverb;
    }
    public string GetAdjective()
    {
      return _adjective;
    }
    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }
  }
}
