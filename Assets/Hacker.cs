using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    
    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
    }

    void ShowMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the combat program");
        Terminal.WriteLine("Press 2 for the street scene");
        Terminal.WriteLine("Press 3 for the matrix");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input) {
        if (input == "menu") {
            ShowMainMenu();
        } else if (input == "1") {
            Terminal.WriteLine("You chose level 1");
        } else if (input == "2") {
            Terminal.WriteLine("You chose level 2");
        } else if (input == "3") {
            Terminal.WriteLine("You chose level 3");
        } else if (input == "matrix") {
            Terminal.WriteLine("Are you the one?");
        } else if (input == "neo") {
            Terminal.WriteLine("I am sorry, you are not the one.");
        } else if (input == "morpheus") {
            Terminal.WriteLine("You're going to have to make a choice.");
        } else if (input == "trinity") {
            Terminal.WriteLine("She thinks you are.");
        } else if (input == "red") {
            Terminal.WriteLine("The girl?");
        } else {
            Terminal.WriteLine("Please choose a valid level");
        }
    }
}
