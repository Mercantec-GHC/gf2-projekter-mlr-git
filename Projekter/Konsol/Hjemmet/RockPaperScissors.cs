using System.Reflection.Metadata.Ecma335;

namespace Hjemmet
{
    public class RockPaperScissors
    {
        public void Start()
        {
            //Console.WriteLine("Sten, Saks, Papir er ikke implementeret endnu.");
            Console.WriteLine($"\nIndtast enten: sten, saks eller papir");

            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1, 4);
            string computer;

            if(randomNumber == 1)
            {
                computer = "sten";
            }
            else if(randomNumber == 2)
            {
                computer = "saks";
            }
            else
            {
                computer = "papir";
            }

                string brugerInput = Console.ReadLine().ToLower();
            
            switch (brugerInput)
            {
                case "sten":
                    Console.WriteLine($"\nDu har valgt {brugerInput}, Computeren valgte {computer}");
                    if (computer == "sten")
                    {
                        Console.WriteLine($"Det blev uafgjort");
                    }
                    else if(computer == "papir")
                    {
                        Console.WriteLine($"Computeren vandt");
                    }
                    else
                    {
                        Console.WriteLine($"Du vandt");
                    }
                    Console.WriteLine($"\nTak for spillet");
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
                    Console.WriteLine($"\nTak for spillet");
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
                    Console.WriteLine($"\nTak for spillet");
                    break;

                default:
                    Console.WriteLine($"\nDu har ikke indtastet sten, saks eller papir");

                    
                    break;
            }

            Console.ReadKey();
        }
    }
}
