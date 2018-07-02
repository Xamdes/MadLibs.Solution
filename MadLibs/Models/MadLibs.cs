using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Models
{
  public class StoryVariable
  {
    private string _noun1;
    private string _verb1;
    private string _adverb;
    private string _verb2;
    private string _noun2;



    public string GetNoun1()
    {
      return _noun1;
    }

    public void SetNoun1(string newNoun)
    {
      _noun1 = newNoun;
    }
    public string GetVerb1()
    {
      return _verb1;
    }

    public void SetVerb1(string newVerb)
    {
      _verb1 = newVerb;
    }

    public string GetAdverb()
    {
      return _adverb;
    }

    public void SetAdverb(string newAdverb)
    {
      _adverb = newAdverb;
    }

    public string GetNoun2()
    {
      return _noun2;
    }

    public void SetNoun2(string newNoun)
    {
      _noun2 = newNoun;
    }
    public string GetVerb2()
    {
      return _verb2;
    }

    public void SetVerb2(string newVerb)
    {
      _verb2 = newVerb;
    }
  }
}
