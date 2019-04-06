using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
    }

    void ShowMainMenu() {
        currentScreen = Screen.MainMenu;
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
        } else if (currentScreen == Screen.MainMenu) {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input) {
        if (input == "1") {
            level = 1;
            StartGame();
        } else if (input == "2") {
            level = 2;
            StartGame();
        } else if (input == "3") {
            level = 3;
            StartGame();
        } else if (input == "matrix") {
            Terminal.WriteLine("Are you the one?");
        } else if (input == "neo") {
            Terminal.WriteLine("I am sorry, you are not the one.");
        } else if (input == "morpheus") {
            Terminal.WriteLine("Red pill or blue pill?");
        } else if (input == "trinity") {
            Terminal.WriteLine("She thinks neo is the one.");
        } else if (input == "oracle") {
            Terminal.WriteLine("You're going to have to make a choice.");
        } else if (input == "red") {
            Terminal.WriteLine("The girl?");
        } else {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame() {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}
