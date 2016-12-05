using System;

public class Move{
 //rolls to pick a random room
 public int Walk (){
     Random r = new Random();
      return r.Next(0,4);
 }



}