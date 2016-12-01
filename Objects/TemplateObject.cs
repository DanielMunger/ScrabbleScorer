using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class ScrabbleScore
  {
    private int _userScore;
    private string _userInput;
    private Dictionary<int, List<string>> _scoreTable = new Dictionary<int, List<string>>
    {
      {1, new List<string> {"a","e","i","o","u","l","n","r","s","t"}},
      {2, new List<string> {"d","g"}},
      {3, new List<string> {"b","c","m","p"}},
      {4, new List<string> {"f","h","v","w","y"}},
      {5, new List<string> {"k"}},
      {8, new List<string> {"j","x"}},
      {10, new List<string> {"q","z"}}
    };

    public ScrabbleScore(string input)
    {
        _userInput = input;
    }
  }
}
