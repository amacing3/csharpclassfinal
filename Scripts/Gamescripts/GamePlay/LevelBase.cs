using System;
public class LevelBase{
    public MainFloorLevel[] rooms = {new MainFloorLevel(), new MainFloorLevel()};
    public LevelBase(){
    //objects[0].environment = {"Dark", "Creaky", "Burned"};
    } 
//Different things happen when you enter certan rooms.
    public void Encounter(int i){
        switch (i){
            case 0:
                Console.WriteLine("You have entered the " + rooms[i] + "You have lost 1 Sanity.");
                PlayerBase.Sanity --;
            break;

            case 1:
                Console.WriteLine("You have entered the " + rooms[i] + ". You have fallen to the basement. You take 1 damage.");
                PlayerBase.Health --;
                //enter the basement level
            break;

            case 2:
                Console.WriteLine("You have entered the " + rooms[i] + ". You slide to the basement.");
                //enter the basement level
            break;

            case 3:
                Console.WriteLine("You have entered the " + rooms[i] + ". You gain 1 knowledge.");
                PlayerBase.Knowledge ++;
            break;

            case 4:
                Console.WriteLine("You have entered the " + rooms[i] + ". You have gained 1 sanity.");
                PlayerBase.Sanity ++;
            break;

            default:
                Console.WriteLine("Your path is clear.");
                //rerun the walk
            break;
        }

    }
}