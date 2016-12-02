using System;
public class LevelBase{
    public MainFloorLevel[] objects = {new MainFloorLevel(), new MainFloorLevel()};
    public LevelBase(){
    //objects[0].environment = {"Dark", "Creaky", "Burned"};
    } 

    public void Encounter(int i){
        switch (i){
            case 0:
                Console.WriteLine("You have entered the " + objects[i] + "You must make a sanity roll to leave.");
                //create player class and roll class
                //make the player do a sanity roll to get 4 or higher
            break;

            case 1:
                Console.WriteLine("You have entered the " + objects[i] + ". You have fallen to the basement. You take 1 damage.");
                //make player loose 1 health
                //enter the basement level
            break;

            case 2:
                Console.WriteLine("You have entered the " + objects[i] + ". You slide to the basement.");
                //enter the basement level
            break;

            case 3:
                Console.WriteLine("You have entered the " + objects[i] + ". You gain 1 knowledge.");
                //player gains 1 knowledge
            break;

            case 4:
                Console.WriteLine("You have entered the " + objects[i] + ". You have gained 1 sanity.");
                //player gains 1 sanity
            break;

            default:
                Console.WriteLine("Your path is clear.");
                //rerun the walk
            break;
        }

    }
}