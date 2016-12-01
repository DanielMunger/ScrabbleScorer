using System;
using System.Collections.Generic;
using ScrabbleScore.Objects;
using Xunit;

namespace ScrabbleScoreTest
{
  public class ScoreTest
  {
    [Fact]
    public void Test1_Scorer_number()
    {
      Scrabble newGame = new Scrabble("cat in a hat");
      int result = newGame.Scorer();

      Assert.Equal(true, result == 14);
    }
  }
}
