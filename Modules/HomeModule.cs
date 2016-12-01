using Nancy;
using ScrabbleScore.Objects;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
          return View["index.cshtml"];
      };
      Post["/score"] = _ => {
        Scrabble newWord = new Scrabble(Request.Form["user-input"]);
        int result = newWord.Scorer();
        return View["index.cshtml", result];
      };
    }
  }
}
