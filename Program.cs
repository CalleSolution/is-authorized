using System;

// # Is Authorised
// ### Del 1

// Skriv en metod isAuthorised som frågar användaren efter tre lösenord och som kontrollerar om alla tre är korrekta. 
//Ni får själva bestämma vilka de rätta lösenorden är.
// Metoden ska returnera true om användaren lyckades, och false annars. 
// Anropa isAuthorised()-metoden från er main-metod, och skriv ut en lämplig gratulationsfras ifall användaren lyckats mata in alla 
//lösenorden
// korrekt. Om användaren inte lyckades ska programmet låta henne försöka fyra gånger till (antalet totala inloggningsförsök man 
//har på sig är fem).

// Tips 1: ni bör hålla räkningen på hur många försök användaren hittils har förbrukat.
// Tips 2: använd loopar.

namespace is_authorized
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            System.Console.WriteLine();
            System.Console.WriteLine(isAuthorised());

            

        }

        public static bool isAuthorised()
        {
            bool guess = true;
            int count = 5;

            while(count > 0)
            {
                System.Console.WriteLine("Mata in ett lösenord:");
                string första = Console.ReadLine();
                
                if (första.ToLower() == "räv" || första.ToLower() == "oxe" || första.ToLower() == "rävoxe")
                {
                    guess = true;
                    count = 5;
                    break;
                }
                else
                {
                    Console.Clear();
                    count--;
                    guess = false;
                    System.Console.WriteLine("Fel lösenord! Du har nu " + (count) + " försök kvar.");
                }
            }
            
            while(count > 0)
            {
                System.Console.WriteLine("Mata in ett andra lösenord:");
                string första = Console.ReadLine();
                
                if (första.ToLower() == "räv" || första.ToLower() == "oxe" || första.ToLower() == "rävoxe")
                {
                    guess = true;
                    count = 5;
                    break;
                }
                else
                {
                    Console.Clear();
                    count--;
                    guess = false;
                    System.Console.WriteLine("Fel lösenord! Du har nu " + (count) + " försök kvar.");

                }
            }
            
            while(count > 0)
            {
                System.Console.WriteLine("Mata in ett tredje lösenord:");
                string första = Console.ReadLine();
                
                if (första.ToLower() == "räv" || första.ToLower() == "oxe" || första.ToLower() == "rävoxe")
                {
                    guess = true;
                    count = 5;
                    break;
                }
                else
                {
                    Console.Clear();
                    count--;
                    guess = false;
                    System.Console.WriteLine("Fel lösenord! Du har nu " + (count) + " försök kvar.");
                }
            }

            count = 0;
                if (guess == true){
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Grattis du klarade det!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Du får försöka en gång till, du misslyckades.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            return guess;
        }
    }
}
