using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller // this will create /home path
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; } // Hello() method is a route, it will create a special path, or pattern, in our application, the /hello path

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; } // another route /home/goodbye in the http://localhost:5000 site

    [Route("/")] // the main page (root)
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
}