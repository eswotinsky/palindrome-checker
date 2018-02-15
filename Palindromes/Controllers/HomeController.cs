using Microsoft.AspNetCore.Mvc;
using Palindromes.Models;
using System.Collections.Generic;

namespace Palindromes.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/")]
    public ActionResult PalindromeResult()
    {
      Palindrome inputtedWord = new Palindrome(Request.Form["enter-user-input"]);
      return View("Index", inputtedWord);
    }
  }
}
