using System;
public class Game{

    public void Start (){
        Console.WriteLine("Please type your name");
        name = Console.ReadLine();
        Console.WriteLine("Chose a profession. Athlete, Scientist, or Priest.");
        profession = Console.ReadLine();
        Console.WriteLine("Welcome " + name + ". You are a " + profession + ". You have entered the mansion.");
        
    }

public string name;
public string profession;
}
