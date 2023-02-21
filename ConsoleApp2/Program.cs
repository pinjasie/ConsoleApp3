using System;
class Program
{
     static void Main(String[] args)
    {
        Console.WriteLine("Tehtävä 7.4");
        Console.WriteLine("-----------");
        Console.WriteLine("Saat 5 mahdollisuutta arvata luvun väliltä 1-12.");
        Console.WriteLine();
        Random rnd = new Random(); //luodaan Random-muuttuja, joka antaa näennäisesti sattumanvaraisen arvon
        int luku = rnd.Next(1, 13); //annetaan luku-muuttujalle arvoksi jokin luku 1-12 väliltä
        int arvaus;
        for (int i = 1; i <= 5; i++) //tehdään toistosilmukka
        {
            Console.Write(i + ". yritys, arvaa luku: ");
            arvaus = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (arvaus == luku)
            {
                Console.WriteLine("Onneksi olkoon, arvasit oikein!");
                return; //lopetetaan ohjelman suoritus arvauksen onnistuessa
            }
            else
            {
                Console.WriteLine("Hähää meni väärin, yritä uudestaan!" + "\n");
            }
        }
        Console.WriteLine("Se oli viimeinen yrityksesi! Oikea vastaus on " + luku); //jos arvaukset on täynnä, kerrotaan vastaus
        }
    }