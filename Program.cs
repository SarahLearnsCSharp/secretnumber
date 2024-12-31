using System;

class Program
{
    
    static int secretNumber;
    static int userGuess;
    static bool playAgain = true;
    public static void generateSecretNumber()
    {
        Random rnd = new Random();
        secretNumber = rnd.Next(1,100);
        //Console.WriteLine(secretNumber);
    }
    public static void receiveGuess()
    {
        string userInput = Console.ReadLine();
        userGuess = int.Parse(userInput);
    }

    public static void compareGuess()
    {
        if (userGuess > secretNumber){
            Console.WriteLine("Your guess was too HIGH. Guess again:");
            receiveGuess();
            compareGuess();
        }
        else if (userGuess < secretNumber){
            Console.WriteLine("Your guess was too LOW. Guess again:");
            receiveGuess();
            compareGuess();
        }
        else if (userGuess == secretNumber){
            Console.WriteLine("You guessed the number!");
            Console.WriteLine("Play Again?");
            Console.WriteLine("Y | N");
            string userPlayAgain = Console.ReadLine();
                if(userPlayAgain == "Y") {
                    playAgain = true;
                 }
                 else if(userPlayAgain == "N") {
                    Console.WriteLine("Bye! Thanks for playing.");
                    playAgain = false;
                 }
                 
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine("               Guess the");
        Console.WriteLine("  ______ ____   ___________   _____/  |_ ");
        Console.WriteLine(" /  ___// __ \\_/ ___\\_  __ \\_/ __ \\   __\\");
        Console.WriteLine(" \\___ \\\\  ___/\\  \\___|  | \\/  ___/|  |  ");
        Console.WriteLine("/____  >\\___  >\\___  >__|    \\___  >__|  ");
        Console.WriteLine("    \\/     \\/     \\/            \\/      ");
        Console.WriteLine("                    ___.                 ");
        Console.WriteLine("  ____  __ __  _____\\_ |__   ___________ ");
        Console.WriteLine(" /    \\|  |  \\/     \\| __ \\_/ __ \\_  __ \\");
        Console.WriteLine("|   |  \\\\  |  /  Y Y  \\\\ \\_\\ \\  ___/|  | \\/");
        Console.WriteLine("|___|  /____/|__|_|  /___  /\\___  >__|   ");
        Console.WriteLine("     \\/            \\/    \\/     \\/       ");
        Console.WriteLine(" ");

        Console.WriteLine("       Sarah's first C# program");
        Console.WriteLine("           Made 30 Dec 2024");
        Console.WriteLine(" ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine(" ");

        while(playAgain == true){
        generateSecretNumber();
        Console.WriteLine("The computer has generated a secret number. ");
        Console.WriteLine("Guess the number: ");
        receiveGuess();
        compareGuess();
        }
    }
    
    
}