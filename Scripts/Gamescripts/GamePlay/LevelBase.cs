using System;
public class LevelBase{

    public void Encounter(int i){
        switch (i){
            case 0:
                Console.WriteLine("You have entered the " + objects[i] + "You must make a sanity roll to leave.");
                //create player class and roll class
                //make the player do a sanity roll to get 5 or higher
            break;

            case 1:
                Console.WriteLine("You have entered the " + objects[i] + ". You have fallen to the basement. You take 2 damage.");
                //make player loose 2 health
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
        }

    }
}