using Nancy;
using Template.Objects;

namespace Template
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View[""];
      Get["/"] = _ => {
        //Action Here
        return View["", //Model];
      };
    }
  }
}
