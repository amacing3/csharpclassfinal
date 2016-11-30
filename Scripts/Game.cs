using System;
public class Game{

    public void Start (){
        //The player must enter a name and choose a profession then they will enter the house.
        Console.WriteLine("Please type your name");
        name = Console.ReadLine();
        Console.WriteLine("Chose a profession. Athlete, Scientist, or Priest.");
        profession = Console.ReadLine();
        Console.WriteLine("Welcome " + name + ". You are a " + profession + ". You have entered the mansion.");

        //the player can choose to walk around the house or stop playing
        //the player will encounter rooms which will affect their stats or change their location.
        
    }

public string name;
public string profession;
}
