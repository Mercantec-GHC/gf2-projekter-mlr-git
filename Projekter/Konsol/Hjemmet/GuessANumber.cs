namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            Console.WriteLine("Gæt et tal er ikke implementeret endnu.");
            
            Random newRandom = new Random();
            int randomNumber = newRandom.Next(1, 100);
            Console.WriteLine($"tallet er: {randomNumber}");

            Console.ReadKey();
        }
    }
}
