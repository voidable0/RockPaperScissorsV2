using System;

class RockPaperScissors
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose one of the three: 1 = Rock 2 = Paper 3 = Scissors");
        int player;
        while (!int.TryParse(Console.ReadLine(), out player) || player < 1 || player > 3)
            Console.WriteLine("choose out of three Are you stupid or what? 1 = Rock 2 = Paper 3 = Scissors");
        int computer = new Random().Next(1, 4);
        Console.WriteLine(player == computer ? "You got tied!" : player % 3 + 1 == computer ? "You won!" : "Computer won!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
