using System;
using System.Collections.Generic;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    hangman();
  }
  public static void hangman(){
    var words = new List <string>(){
    "psychology",
    "kangaroo",
    "indent",
    "array",
    "balistics"
    };
    Random rnd = new Random();
    var still_want_To_play = false;
    while (still_want_To_play == false){
      string s = words[rnd.Next(words.Count)];
      WriteLine("Fill in the word: ");
      var w = new List<char>();
      foreach (char letter in s){
        Write("_ ");
      }
      WriteLine("");
      var final = "";
      while (final != s){
        WriteLine("What is your geussed word or letter? ");
        var input = ReadLine();
        if (input != final){
          if (s.Contains(input)){
            WriteLine("Good guess");
            final += input;
            WriteLine(final);
          }
          else{
            WriteLine("Wrong guess!");
          }
        }
      }
      
      WriteLine("");
      WriteLine("Do you want another word? ");
      var question = ReadLine();
      var q = question.ToLower();
      if (q == "no"){
        still_want_To_play = true;
      }
    }
  }
}