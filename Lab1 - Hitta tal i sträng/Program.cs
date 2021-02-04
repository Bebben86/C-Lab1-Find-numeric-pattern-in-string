using System;

namespace Lab1___Hitta_tal_i_sträng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Lab1 av Andreas Nilsson");
            Console.WriteLine("--------------------------------------");
            Console.Write("\nMata in en sträng: ");
            string inputString = Console.ReadLine(); // strängen som användaren matar in
            Console.WriteLine();

            Int64 sum = 0; // Variabel för att hålla och räkna ut summan.
            

            for (int i = 0; i < inputString.Length -1; i++) // Kör igenom hela strängen, förutom sista tecknet.
            {
                if (!int.TryParse(inputString[i].ToString(), out _)) // skippar en iteration om den hittar bokstav. discard.
                {
                    continue;
                }
                string total = ""; // Håller blåmarkerade tal som sträng tills de parsas till Int64.
                for (int j = i + 1; j < inputString.Length; j++)
                {
                    if (!int.TryParse(inputString[j].ToString(), out _)) // "klipper" vid bokstav. discard.
                    {
                        break;
                    }
                    if (inputString[i] == inputString[j]) //När den hittat två lika tecken
                    {
                        for (int k = i; k <= j; k++) // adderar värden på hittade tal.
                        {
                            total += inputString[k]; 
                        }

                        sum += Int64.Parse(total);
                        Console.Write("   "); 

                        for (int m = 0; m < inputString.Length; m++)
                        {
                            if (m >= i && m <= j) // avgör om det ska skrivas i blått eller gult.
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; 
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow; 
                            }
                            Console.Write(inputString[m]); //själva utskriften
                        
                        }
                        Console.WriteLine();
                        break;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nSumman av blåmarkerade tal är: {sum}");

            Console.Write("\nTryck valfri tangent för att avsluta.");
            Console.ReadKey();
        }
    }
}
