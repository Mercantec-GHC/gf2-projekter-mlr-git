using System;
using Hjemmet;
using Kontoret;
using Enterprice;

bool run = true;
while (run)
{
    PrintMenu();
    string valg = Console.ReadLine() ?? "?";

    switch (valg)
    {
        case "1":
            // Kald GuessANumber
            GuessANumber guessANumber = new GuessANumber();
            guessANumber.Start();
            break;
        case "2":
            // Kald RockPaperScissors
            RockPaperScissors rockPaperScissors = new RockPaperScissors();
            rockPaperScissors.Start();
            break;
        case "3":
            // Kald TicTacToe
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Start();
            break;
        case "4":
            // Kald BinaryConverter
            Console.WriteLine("Vælg venligst, om der skal konverters fra decimal til binær, eller omvendt.");
            Console.WriteLine("Tast \"1\" for decimal til binær, eller \"2\" for binær til decimal:");
            string binOrDec = Console.ReadLine();

            switch (binOrDec)
            {
                case "1":
                    //Kalder DecimalConverter
                    DecimalConverter decimalConverter = new DecimalConverter();
                    decimalConverter.Start();
                    break;

                case "2":
                    //Kalder BinaryConverter
                    BinaryConverter binaryConverter = new BinaryConverter();
                    binaryConverter.Start();
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen:");
                    Console.ReadKey();
                    break;
            }
            break;
        case "5":
            // Kald ADService
            ADService adService = new ADService();
            adService.Start();
            break;
        case "?":
            PrintMenu();
            break;
        case "exit":
            run = false;
            break;
        default:
            Console.WriteLine("Ugyldigt valg. Prøv igen.");
            Console.ReadKey();
            break;
    }
}

void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("Vælg et program:");
    Console.WriteLine("1. Gæt et tal");
    Console.WriteLine("2. Sten, Saks, Papir");
    Console.WriteLine("3. Tic-Tac-Toe");
    Console.WriteLine("4. Binærkodeomformer");
    Console.WriteLine("5. AD Brugeroversigt");
    Console.WriteLine("?. Help");
    Console.WriteLine("exit. Afslut");
    Console.Write("Indtast valg: ");
}
