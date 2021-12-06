using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("GO NO FURTHER, MORTAL. ANSWER MY RIDDLES THREE, OR BE DEVOURED. ALSO I'M SUPER HUNGRY SO IF YOU SPEAK WITH ANY UPPERCASE LETTERS I'M JUST GONNA EAT YOU ANYWAYS.");
    Console.WriteLine("QUESTION ONE. THE MORE YOU TAKE FROM ME, THE LARGER I BECOME. WHAT AM I?");
    string answer1 = Console.ReadLine();
    if (answer1 == "hole" || answer1 == "a hole" || answer1 == "a hole in the ground" || answer1 == "a hole in the earth" || answer1 == "a hole in the Earth" || answer1 == "pit" || answer1 == "a pit")
    {
      Console.WriteLine("...THAT WILL DO. QUESTION TWO. WE ARE ALWAYS THERE BUT NOT ALWAYS SEEN. WE SHOW OURSELVES WHEN ONE OF US LEAVES. WHAT ARE WE?");
      string answer2 = Console.ReadLine();
      if (answer2 == "stars" || answer2 == "the stars" || answer2 == "a star")
      {
        Console.WriteLine("...VERY WELL. LAST QUESTION. I WALK ON FOUR LEGS IN THE MORNING, TWO LEGS IN THE AFTERNOON, AND THREE LEGS IN THE EVENING. WHAT AM I?");
        string answer3 = Console.ReadLine();
        if (answer3 == "man" || answer3 == "a man" || answer3 == "a woman" || answer3 == "a person" || answer3 == "human" || answer3 == "a human" || answer3 == "humans" || answer3 == "humanity")
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
