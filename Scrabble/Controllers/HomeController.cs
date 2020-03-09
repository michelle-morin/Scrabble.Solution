using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/score")]
    public ActionResult Score(string word)
    {
      Word userWord = new Word(word);
      userWord.CheckScore();
      return View(userWord);
    }
  }
}