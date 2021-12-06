using System;
using System.Collections.Generic;
using Sphinx.Models;

class Program
{
  static void Main()
  {
    Riddle riddle1 = new Riddle("THE MORE YOU TAKE FROM ME, THE LARGER I BECOME. WHAT AM I?", new List<string> {"hole", "a hole", "a hole in the ground", "a hole in the earth", "pit", "a pit"});
    Riddle riddle2 = new Riddle("WE ARE ALWAYS THERE BUT NOT ALWAYS SEEN. WE SHOW OURSELVES WHEN ONE OF US LEAVES. WHAT ARE WE?", new List<string> {"stars", "the stars", "a star"});
    Riddle riddle3 = new Riddle("I WALK ON FOUR LEGS IN THE MORNING, TWO LEGS IN THE AFTERNOON, AND THREE LEGS IN THE EVENING. WHAT AM I?", new List<string> {"man", "a man", "woman", "a woman", "a person", "human", "a human", "humans", "humanity"});
    Riddle riddle4 = new Riddle("WHAT HAS NO LOCKS DOORS HINGES OR LIDS, BUT INSIDE GOLDEN TREASURE IS HID(den?)", new List<string> {"egg", "an egg", "eggs"});
    List<Riddle> riddles = new List<Riddle> {riddle1, riddle2, riddle3, riddle4};
    Random rand = new Random();

    Riddle RandomRiddle()
    {
      Riddle pickedRiddle = riddles[rand.Next(0, riddles.Count)];
      riddles.Remove(pickedRiddle);
      return pickedRiddle;
    }

    Riddle currentRiddle =  RandomRiddle();
    Console.WriteLine("GO NO FURTHER, MORTAL. ANSWER MY RIDDLES THREE, OR BE DEVOURED. ALSO I'M SUPER HUNGRY SO IF YOU SPEAK WITH ANY UPPERCASE LETTERS I'M JUST GONNA EAT YOU ANYWAYS.");
    Console.WriteLine(currentRiddle.GetRiddleText());
    string answer1 = Console.ReadLine();
    if (currentRiddle.CheckAnswer(answer1))
    {
      currentRiddle =  RandomRiddle();
      Console.WriteLine(currentRiddle.GetRiddleText());
      string answer2 = Console.ReadLine();
      if (currentRiddle.CheckAnswer(answer2))
      {
        currentRiddle =  RandomRiddle();
        Console.WriteLine(currentRiddle.GetRiddleText());
        string answer3 = Console.ReadLine();
        if (currentRiddle.CheckAnswer(answer3))
        {
          Console.WriteLine("...THAT MAKES THREE CORRECT ANSWERS. YOU MAY PASS. AND PLEASE TELL ME WHAT'S GOING ON IN THERE WHEN YOU COME BACK. NOBODY TELLS ME ANYTHING.");
        } 
        else 
        {
          Console.WriteLine("...CLOSE. BUT TWO CORRECT ANSWERS IS NOT ENOUGH. PLEASE GO STEP ON THE GIANT DINNER SAUCER.");
        }
      } 
      else 
      {
        Console.WriteLine("...THAT IS INCORRECT. I AM GOING TO OPEN MY MOUTH NOW AND YOU'RE GOING TO WALK IN.");
      }
    } 
    else 
    {
      Console.WriteLine("...YOU HAVE ANSWERED WRONG. GO SEASON YOURSELF AND RETURN IN NO LATER THAN HALF AN HOUR.");
    }
  }
}
