using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "Lina";
            myLetterVariable.Sender = "Jasmine";
            myLetterVariable.Location = "Portland, ME";
            myLetterVariable.Souvenir = "piece of ice, ha";
            return View(myLetterVariable);
        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/postcard")]
        public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
        {
            LetterVariable myLetterVariables = new LetterVariable();
            myLetterVariables.Recipient = recipient;
            myLetterVariables.Sender = sender;
            myLetterVariables.Location = location;
            myLetterVariables.Souvenir = souvenir;
            return View(myLetterVariables);
        }

    }
}