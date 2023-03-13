using System;

class MainClass
{
    static void RunGame() {
        var random = new Random();
        string[] choices = { "rock", "paper", "scissors" };
        Console.Write("Enter your choice (rock, paper, scissors): ");
        string playerChoice = Console.ReadLine().ToLower();
        if (!Array.Exists(choices, x => x == playerChoice)) RunGame();
        int computerChoiceIndex = random.Next(choices.Length);
        Console.WriteLine($"You chose {playerChoice}, computer chose {choices[computerChoiceIndex]}.");
        if (playerChoice == choices[computerChoiceIndex]) Console.WriteLine("It's a tie!");
        else if ((playerChoice == "rock" && choices[computerChoiceIndex] == "scissors") || (playerChoice == "paper" && choices[computerChoiceIndex] == "rock") || (playerChoice == "scissors" && choices[computerChoiceIndex] == "paper")) Console.WriteLine("You win!");
        else Console.WriteLine("Computer wins!");
        Console.Write("Do you want to play again? (y/n): ");
        if (Console.ReadLine().ToLower() == "y") RunGame();
        else Console.WriteLine("Thanks for playing!");
    }
    static void Main() {
        RunGame();
    }
}

//This code is much shorter by removing unnecessary code. 
//Having the logic into a single recursive function Play(). However i sacrificed alot of readability 
// this was primarly reason it took so long to make because i kept getting lost within the code but it works 



