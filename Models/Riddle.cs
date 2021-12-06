using System;
using System.Collections.Generic;

namespace Sphinx.Models
{
  public class Riddle
  {
    private string _riddleText;
    private List<string> _correctAnswers = new List<string> {};
    
    public Riddle(string riddleText, List<string> correctAnswers)
    {
      _riddleText = riddleText;
      _correctAnswers = correctAnswers;
    }

    public string GetRiddleText()
    {
      return _riddleText;
    }

    public bool CheckAnswer(string guess)
    {
      return (_correctAnswers.Contains(guess));
    }
  }
}