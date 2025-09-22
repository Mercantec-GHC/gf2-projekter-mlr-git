using System.Reflection.Metadata.Ecma335;

namespace Hjemmet
{
    public class RockPaperScissors
    {
        private string computer = "";
        public void Start()
        {
            Console.WriteLine($"\nSten, Saks, Papir - Indtast enten: sten, saks eller papir");

            SetComputerChoice();
            bool gameComplete = false;
            string brugerInput = Console.ReadLine().ToLower();
            
            while(!gameComplete)
            {
                string playAgain;
                bool inputCheck = false;

                switch (brugerInput)
                {
                    case "sten":
                        Console.WriteLine($"\nDu har valgt {brugerInput}, Computeren valgte {computer}");
                        if (computer == "sten")
                        {
                            Console.WriteLine($"Det blev uafgjort");
                        }
                        else if (computer == "papir")
                        {
                            Console.WriteLine($"Computeren vandt");
                        }
                        else
                        {
                            Console.WriteLine($"Du vandt");
                        }
                        Console.WriteLine("\nØnsker du at spille igen? - indtast ja / nej");
                        playAgain = Console.ReadLine().ToLower();
                        
                        while (!inputCheck)
                        {
                            switch (playAgain)
                            {
                                case "ja":
                                    SetComputerChoice();
                                    Console.WriteLine("\nIndtast enten: sten, saks eller papir:");
                                    brugerInput = Console.ReadLine();
                                    inputCheck = true;
                                    break;

                                case "nej":
                                    inputCheck = true;
                                    gameComplete = true;
                                    break;

                                default:
                                    Console.WriteLine($"\nDu har ikke indtastet ja eller nej, prøv venligst igen.");
                                    playAgain = Console.ReadLine();
                                    break;
                            }
                        }
                        break;

                    case "saks":
                        Console.WriteLine($"\nDu har valgt {brugerInput}, Computeren valgte {computer}");
                        if (computer == "saks")
                        {
                            Console.WriteLine($"Det blev uafgjort");
                        }
                        else if (computer == "sten")
                        {
                            Console.WriteLine($"Computeren vandt");
                        }
                        else
                        {
                            Console.WriteLine($"Du vandt");
                        }
                        Console.WriteLine("\nØnsker du at spille igen? - indtast ja / nej");
                        playAgain = Console.ReadLine().ToLower();
                        
                        while (!inputCheck)
                        {
                            switch (playAgain)
                            {
                                case "ja":
                                    SetComputerChoice();
                                    Console.WriteLine("\nIndtast enten: sten, saks eller papir:");
                                    brugerInput = Console.ReadLine();
                                    inputCheck = true;
                                    break;

                                case "nej":
                                    inputCheck = true;
                                    gameComplete = true;
                                    break;

                                default:
                                    Console.WriteLine($"\nDu har ikke indtastet ja eller nej, prøv venligst igen.");
                                    playAgain = Console.ReadLine();
                                    break;
                            }
                        }
                        break;

                    case "papir":
                        Console.WriteLine($"\nDu har valgt {brugerInput}, Computeren valgte {computer}");
                        if (computer == "papir")
                        {
                            Console.WriteLine($"Det blev uafgjort");
                        }
                        else if (computer == "saks")
                        {
                            Console.WriteLine($"Computeren vandt");
                        }
                        else
                        {
                            Console.WriteLine($"Du vandt");
                        }
                        Console.WriteLine("\nØnsker du at spille igen? - indtast ja / nej");
                        playAgain = Console.ReadLine().ToLower();
                        
                        while (!inputCheck)
                        {
                            switch (playAgain)
                            {
                                case "ja":
                                    SetComputerChoice();
                                    Console.WriteLine("\nIndtast enten: sten, saks eller papir:");
                                    brugerInput = Console.ReadLine();
                                    inputCheck = true;
                                    break;

                                case "nej":
                                    inputCheck = true;
                                    gameComplete = true;
                                    break;

                                default:
                                    Console.WriteLine($"\nDu har ikke indtastet ja eller nej, prøv venligst igen.");
                                    playAgain = Console.ReadLine();
                                    break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine($"\nDet indtastede \"{brugerInput}\" er ikke sten, saks eller papir. Prøv venligst igen:");
                        brugerInput = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("\nTak for spillet.");
            Console.WriteLine("\nTryk på en tast, for at vende tilbage til hovedmenuen.");
            Console.ReadKey();
        }

        private void SetComputerChoice()
        {
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1, 4);

            if (randomNumber == 1)
            {
                computer = "sten";
            }
            else if (randomNumber == 2)
            {
                computer = "saks";
            }
            else
            {
                computer = "papir";
            }
        }
    }
}
