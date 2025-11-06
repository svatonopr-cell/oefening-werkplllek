using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PClass.Models;



namespace App
{
    public class App
    {
        static void Main()
        {
            const string user = "Admin", password = "P@sswoord123";
            int tries = 0;
        while (tries < 3)
        {
        Console.Write("Gebruikersnaam: ");
        string inputUser = Console.ReadLine();
        Console.Write("Wachtwoord: ");
        string inputPassword = Console.ReadLine();
        if (inputUser == user && inputPassword == password)
        {
        Console.WriteLine($"Welkom, {inputUser}!");
        return;
        }
        tries++;
        Console.WriteLine($"Foutieve login.\n{3-tries} pogingen over.");
        }
        Console.WriteLine("Te veel pogingen. Toegang geweigerd.");
        }
        }
    }

    

