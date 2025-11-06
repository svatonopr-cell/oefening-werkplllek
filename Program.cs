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
           
        Console.Write("Gebruikersnaam: ");
        string inputUser = Console.ReadLine();
        Console.Write("Wachtwoord: ");
        string inputPassword = Console.ReadLine();
        if (inputUser == user && inputPassword == password)
        {
        Console.WriteLine($"Welkom, {inputUser}!");
        return;
        
        }
    }
}
    

