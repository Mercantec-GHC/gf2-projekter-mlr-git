using System.Text;

namespace Kontoret
{
    public class BinaryConverter
    {
        private string converted = "";
        private string userInput = "";
        
        public void Start()
        {
            //Console.WriteLine($"Velkommen til Binary Converter");
            //Console.WriteLine($"Dette program kan konvertere en IPv4 adresse fra decimal tal til binær eller omvendt");
            int inputInt = 0;
            
            Console.WriteLine($"\nIndtast octet:");

            while (true)
            {
                if (int.TryParse(userInput = Console.ReadLine(), out inputInt))
                {
                    if (userInput.Length <= 3) //Hvis længden af brugerinput er lig med eller mindre end 3, går vi ud fra at der skal konverteres fra decimal til binær.
                    {
                        inputInt = int.Parse(userInput);
                        ConvertToBin(inputInt);
                        Console.WriteLine($"{converted}");
                    }
                    else if(userInput.Length >= 4){ //Hvis længden af brugerinput er lig med, eller større ind 4, går vi ud fra at der skal konverteres fra binær til decimal.
                        //inputInt = int.Parse(userInput);
                        ConvertToDec(userInput);
                        Console.WriteLine($"{converted}");
                    }
                        break;
                }
                else
                {
                    Console.WriteLine($"\nDet indtastede, \"{userInput}\", er ikke et heltal, prøv venligst igen:");
                    userInput = Console.ReadLine();
                }
            }

            Console.WriteLine("Tryk på en tast, for at vende tilbage til hovedmenuen.");
            Console.ReadKey();
        }
        
        private void ConvertToBin(int octet) //Konverterer et heltal (på 3 cifre eller mindre), til binær. Hvis det binære tal er mindre end 8 cifre, formateres tallet til at have 8 cifre.
        {
            //List<char> binConvert = new List<char>();
            StringBuilder binConvert = new StringBuilder();
            StringBuilder temp = new StringBuilder();
            
            while(octet > 0)
            {
                if(octet % 2 == 0)
                {
                    binConvert.Append('0');
                    octet = octet / 2;
                    ConvertToBin(octet);
                }
                else
                {
                    binConvert.Append('1');
                    octet = octet / 2;
                    ConvertToBin(octet);
                }
            }

            if(binConvert.Length < 8)
            {
                for(int i = 8 - binConvert.Length; i > 0; i--)
                {
                    binConvert.Append('0');
                }
            }
            
            char[] resultReverse = binConvert.ToString().ToCharArray();
            Array.Reverse(resultReverse);
            
            foreach(char c in resultReverse)
            {
                temp.Append(c);
            }
            
            temp.Insert(4, "'");
            converted = temp.ToString();
            
        }
        
        private void ConvertToDec(string octet) //Tager et 8 bit binær tal og konverterer til decimal (base 2)
        {
            double sum = 0;

            for(int i = 0; i < 8; i++) 
            {
                if(octet[i] == '1')
                {
                    sum += Math.Pow(2, 7 - i);
                }
            }

            converted = sum.ToString();
        }
    }
}
