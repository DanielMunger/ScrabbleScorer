using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class Scrabble
  {
    private int _userScore;
    private string _userInput;
    private Dictionary<int, List<char>> _scoreTable = new Dictionary<int, List<char>>
    {
      {1, new List<char> {'a','e','i','o','u','l','n','r','s','t'}},
      {2, new List<char> {'d','g'}},
      {3, new List<char> {'b','c','m','p'}},
      {4, new List<char> {'f','h','v','w','y'}},
      {5, new List<char> {'k'}},
      {8, new List<char> {'j','x'}},
      {10, new List<char> {'q','z'}}
    };
    public Scrabble(string input)
    {
        _userInput = input.ToLower();
        _userScore = 0;
    }
    public int Scorer()
    {
      for(int i = 0; i < _userInput.Length; i++)
      {
        foreach(var pair in _scoreTable)
        {
          for(int j = 0; j < pair.Value.Count; j++)
          {
            if(pair.Value[j] == _userInput[i])
            {
              _userScore += pair.Key;
            }
          }
        }
      }
      return _userScore;
    }
  }
}
