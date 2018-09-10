using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
     public ActionResult MadLib()
     {
       return View();
     }
    [Route("/mad_lib")]
    public ActionResult MadLibFill()
    {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetPronoun(Request.Query["pronoun"]);
        myLetterVariable.SetVerb(Request.Query["verb"]);
          myLetterVariable.SetNoun(Request.Query["noun"]);
        return View("MadLibFill", myLetterVariable);
    }
  }
}
