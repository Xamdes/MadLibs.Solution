using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MadLibs.Models;
using System;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
    [Route("/ViewMadLib")]
    public ActionResult ViewMadLib()
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.SetNoun1(Request.Query["first-noun"]);
      myStoryVariable.SetVerb1(Request.Query["first-verb"]);
      myStoryVariable.SetAdverb(Request.Query["first-adverb"]);
      myStoryVariable.SetVerb2(Request.Query["second-verb"]);
      myStoryVariable.SetNoun2(Request.Query["second-noun"]);
      return View(myStoryVariable);
    }
  }
}
