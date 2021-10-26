using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        public static Animal SellAnimal(string Dog, string Animal);
        public static Animal SellAnimal(string Cat, string Animal);
        public static Animal SellAnimal(string Fish, string Animal)

            

        {
            List<string> NoAnimal = new List<string>();
            List<string> AnimalFish = new List<string>();
            List<string> AnimalCat = new List<string>();
            List<string> AnimalDog = new List<string>();

            NoAnimal.Add("Crocodile");
            NoAnimal.Add("Bird");
            NoAnimal.Add("Gorilla");

            AnimalDog.Add("Siberian Husky");
            AnimalDog.Add("German Sheperd");
            AnimalDog.Add("labrador retriever");

            AnimalCat.Add("Siamese cat");
            AnimalCat.Add("british short hair");
            AnimalCat.Add("Maine Coon");

            AnimalFish.Add("Common carp");
            AnimalFish.Add("blobfish");
            AnimalFish.Add("Asian arowana");
            {
                Console.WriteLine("What animal are you looking for ? : " + AnimalDog + AnimalCat + AnimalFish);
                
            }
            if (AnimalDog) ;

            else
                Console.WriteLine("You chose to buy a dog" + AnimalDog);
            Console.ReadKey();
            {
                if (AnimalCat) ;
                else
                    Console.WriteLine("You have chosen  Cat" + AnimalCat);
                Console.ReadKey();
                {
                    if (AnimalFish) ;
                    else
                        Console.WriteLine("You have Chosen to buy a fish" + AnimalFish);
                    Console.ReadKey();
                }
            }
                    
            }
        }
    }







