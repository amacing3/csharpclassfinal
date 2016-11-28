using System.Collections.Generic;
using System;
public class WeaponList {

    //List
    public List<string> listOfWeapons;

    //Array
    public string[] arrayOfWeapons = {"Gun", "Knife", "Bow"};

    public void RunArray () {
        Console.WriteLine(arrayOfWeapons.Length);
        
        foreach (string weapon in arrayOfWeapons) {
            Console.WriteLine(weapon);
        }
    }
}