namespace HomeworkDataTypes;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        string playerName;
        int snakeSpeed;
        int score = 0;
        char fieldBoarder = '#';
        bool isGameOver = false;
        
        // Task 2
        Console.WriteLine("Name your snake: ");
        playerName = Console.ReadLine();
        
        Console.WriteLine("Which speed will you choose (from 1 to 5)? ");
        snakeSpeed = int.Parse(Console.ReadLine());
        
        // Task 3
        Console.WriteLine("Hello, " + playerName + "! Your current score is: " + score + ". Game speed: " + snakeSpeed);
    }
}