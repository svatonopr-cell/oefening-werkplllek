using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PClass.Models;



namespace App
{
    public class App
    {
        public static void Main(string[] args)
        {
            Console.Write("Wat is de naam van je favoriete album? ");
            string album = Console.ReadLine();

            Console.Write("Op welke datum werd het uitgebracht? ");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            Console.Write("hoeveel nummers staan er op het album? ");
            string Nummers = Console.ReadLine();
            
            Console.Write("Hoe lang duurt het album in totale? (minuten) ");
            string duurt = Console.ReadLine();

       
            
            Album p = new Album();
            p.NameAlbum = album;
            p.Datum = datum;
            p.Nummers = int.Parse(Nummers);
            p.Duurt = int.Parse(duurt);

            p = new Album(album, lastName);
            p.Birthdate = birthDate;
            p.Salary = (double)salary;
            Console.WriteLine(p.ToString());
            int percentage;
            while (!int.TryParse(Console.ReadLine(), out percentage) && 
                   percentage < 0 && percentage > 100)
            {
                Console.WriteLine("Ongeldige invoer");
            }
            p.IncreaseSalery(percentage);
            Console.WriteLine(ShowDetails(p));

        }
            private static string ShowDetails(product product)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------------------");
            sb.AppendLine($"Werknemer: {product.Firstname} {product.Lastname}");
            sb.AppendLine($"Gebortedatum: {product.Birthdate.ToLongDateString()} ({product.Age})");
            sb.AppendLine($"Salaris: {product.Salary:C2}");
            sb.AppendLine("-----------------------");
            sb.AppendLine($"Samenvatting : {product.ToString()}");
            sb.AppendLine("-----------------------");
            



            return sb.ToString();
        }
        }
    }

    

