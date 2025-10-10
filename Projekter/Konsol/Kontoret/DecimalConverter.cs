using System.ComponentModel.Design;
using System.Net.Mime;

namespace Kontoret
{
    public class DecimalConverter
    {
        public void Start()
        {
            Console.WriteLine("Velkommen til Decimal IP til Binær IP konverter!");
            Console.WriteLine("Indtast en IPv4-adresse (f.eks. 10.20.10.1), eller skriv 'exit' for at afslutte.");

            var history = new List<string>();

            while (true)
            {
                Console.Write("IP: ");
                string ipInput = Console.ReadLine() ?? "";

                if (ipInput.Trim().ToLower() == "exit")
                    break;

                string binary = IpToDec(ipInput);
                if (binary != null)
                {
                    string result = $"IP: {ipInput} => Converted output: {binary}";
                    Console.WriteLine(result);
                    history.Add(result);
                }
                else
                {
                    Console.WriteLine("Ugyldig IP-adresse.");
                }
            }

            Console.WriteLine("\nHistorik over konverteringer:");
            foreach (var entry in history)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("Tryk på en tast for at afslutte...");
            Console.ReadKey();
        }

        private string IpToDec(string ip)
        {
            var parts = ip.Split('.');
            if (parts.Length != 4) return null;

            var binaryParts = new List<string>();
            foreach (var part in parts)
            {
                if (!int.TryParse(part, out int num) || num < 0 || num > 255)
                    return null;
                string bin = "";
                int value = num;
                for (int i = 7; i >= 0; i--)
                {
                    int mask = 1 << i;
                    bin += (value & mask) != 0 ? "1" : "0";
                }
                binaryParts.Add(bin);
            }
            return string.Join(".", binaryParts);
        }
    }
}

