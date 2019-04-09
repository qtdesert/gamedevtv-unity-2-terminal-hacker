using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game configuration data
    const string menuHint = "You may type menu at any time.";
    string[] level1Passwords = { "kungfu", "jujitsu", "dojo", "learn", "fight" };
    string[] level2Passwords = { "agentsmith", "woman", "red", "suits", "pause" };
    string[] level3Passwords = { "nabuchadnezzar", "realworld", "green", "phone", "codes" };

    // Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

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
        } else if (currentScreen == Screen.Password) {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input) {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber) {
            level = int.Parse(input);
            AskForPassword();
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
            Terminal.WriteLine(menuHint);
        }
    }

    void AskForPassword() {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine("Enter your password, hint: " + password.Anagram());
        Terminal.WriteLine(menuHint);
    }

    void SetRandomPassword() {
        switch (level) {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
    }

    void CheckPassword(string input) {
        if (input == password) {
            DisplayWinScreen();
        } else {
            AskForPassword();
        }
    }
    
    void DisplayWinScreen() {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);
    }

    void ShowLevelReward() {
        switch(level) {
            case 1:
                Terminal.WriteLine("Enter the combat program...");
                Terminal.WriteLine(@"
      ___   )            ,  @
   @___, \ /          @__\  /\
  /\__,   |          /\_, \/ /
 / \    / @\        / \   (
/__|___/___/_______/__|____\__
"
                );
                break;
            case 2:
                Terminal.WriteLine("Enter the street program...");
                Terminal.WriteLine(@"
     ___________
    //   |||   \\
 __//____|||____\\____
| _|      |       _  ||
|/ \______|______/ \_||
_\_/_____________\_/___
"
                );
                Terminal.WriteLine("Play again for a greater challenge.");
                break;
            case 3:
                Terminal.WriteLine("Welcome the matrix.");
                Terminal.WriteLine(@"
                |       _)        
 __`__ \   _` | __|  __| |\ \  / 
 |  |   | (   | |   |    | `  <  
_| _|  _|\__,_|\__|_|   _| _/\_\
"
                );
                break;
            default:
                Debug.LogError("Invalid level reached");
                break;
        }
    }
}
