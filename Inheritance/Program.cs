using System;
using System.Net.NetworkInformation;

namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)

        {
            var myBird = new Bird();

            myBird.BirthDate = 0;
            myBird.HeartBeat = true;
            myBird.MatingRitual = "Attractive";
            myBird.EnemiesCount = 50;



            Console.WriteLine("------------------");


            var myReptile = new Reptile();
            myReptile.TinySharpTeeth = 30;
            myReptile.FamilyName3 = "lizards";
            myReptile.LongTongues = true;

            var myAnimals = new Animal[] { myBird, myReptile };
            foreach (var Animal in myAnimals)
            {
                Console.WriteLine($" My family name is:{Animal.FamilyName}");
                Console.WriteLine($" {Animal.HeartBeat}I do have a heart beat.");
                Console.WriteLine($" My birthdate is: {Animal.BirthDate}");
                Console.WriteLine($" I have {Animal.EnemiesCount} enemies.");
            }
        }
    }
}
