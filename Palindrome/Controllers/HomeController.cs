using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using Palindrome.Models;

namespace PalindromeController
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }
    [HttpPost("/result")]
    public ActionResult Result()
    {
      WordCheck newCheck = new WordCheck(Request.Form["palindrome"]);
      return View("result", newCheck);
    }
  }
}
