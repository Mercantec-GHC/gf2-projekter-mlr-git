namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            //Console.WriteLine("Gæt et tal er ikke implementeret endnu.");
            
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1, 100);
            
            bool isValid = false;
            Console.WriteLine($"\nGæt et tal - indtast et heltal:");
            string brugerInput = Console.ReadLine();
            int number = 0;

            while (!isValid)
            {
                if(int.TryParse(brugerInput, out number))
                {
                    if(number < randomNumber)
                    {
                        Console.WriteLine($"\nDit gæt er lavere end tallet - gæt igen");
                        brugerInput = Console.ReadLine();
                    }
                    else if(number > randomNumber)
                    {
                        Console.WriteLine($"\nDit gæt er højere end tallet - gæt igen");
                        brugerInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"\nTillykke! - Du har gættet det korrekte tal \"{randomNumber}\".");
                        isValid = true;
                    }
                }
                else
                {
                    Console.WriteLine($"\nDet indtastede er ikke et heltal. Prøv igen.");
                    brugerInput = Console.ReadLine();
                }                
            }
            Console.ReadKey();
        }
    }
}
