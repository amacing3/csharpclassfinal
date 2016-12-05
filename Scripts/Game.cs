using System;
public class Game{

    public Move move;
    public LevelBase level;

    public Game() {
        move = new Move();
        level = new LevelBase();


    }

    public void Start (){
        //The player must enter a name and choose a profession then they will enter the house.
        Console.WriteLine("Please type your name");
        name = Console.ReadLine();
        Console.WriteLine("Chose a profession. Athlete, Scientist, or Priest.");
        profession = Console.ReadLine();
        //the chosen profession changes the player stats
        if (profession == "Athlete"){
           PlayerBase.Health = 6;
        } else if (profession == "Scientist"){
            PlayerBase.Knowledge = 6;
        } else if (profession == "Priest"){
            PlayerBase.Sanity = 6;
        }

    //the player can choose to walk around the house or stop playing
        Console.WriteLine("Welcome " + name + ". You are a " + profession + ". You have entered the mansion.");
        Console.WriteLine("Pick one: Play or End");
        gameState = Console.ReadLine();
    //the player will encounter rooms which will affect their stats or change their location.
        if (gameState == "Play"){
            //runs the move function
            level.Encounter(move.Walk());
        }else if (gameState == "End"){
            Console.WriteLine("Game over.");
        }
        
        
        
    }

public string name;
public string profession;
public string gameState;
}
