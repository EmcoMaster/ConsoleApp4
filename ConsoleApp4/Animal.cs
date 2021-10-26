using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{


    class Animal
    {
        public string Make { get; set; }
        public string Typeofdogs { get; set; }
        public string Choosedog { get; set; }

        public string Storename { get; set; }
        public string name;
        public int age;
        public float happiness;

        public void PrintBase()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hapiness: " + happiness);
        }

    }
    class Dog : Animal
    {
        public int spotCount;
        public void Bark()
        {


            Console.WriteLine("WUF!");
        }
        class Cat : Animal
        {
            public float cuteness;
            public void Meow()
            {
                Console.WriteLine("MEOW!");
            }
        }
        class Fish : Animal
        {
            public void slurp()
            {
                Console.WriteLine("vatten ljud");
            }
        }
        class AnimalShop : Animal
        {
            public void animalshop()
            {
                Console.WriteLine("what animal would you like to buy ?");
            }
        }

        public string Typeofanimal { get; set; }
        public string Chooseanimal { get; set; }

        public string Storename { get; set; }

        

    }
}
 
    

    

