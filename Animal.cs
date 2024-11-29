using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public abstract class Animal
    {
        protected Animal(int age, string eyeColor, int numberOfLegs, bool fur)
        {
            this.age = age;
            this.eyeColor = eyeColor;
            this.numberOfLegs = numberOfLegs;
            this.fur = fur;
        }

        public string type { get; set; }
        public int age { get; set; }
        public string eyeColor { get; set; }
        public int numberOfLegs { get; set; }
        public bool fur { get; set; }

        public void Eat()
        {
            Console.WriteLine($"the {type} is eating");
        }

        public void sleep()
        {
            Console.WriteLine($"the {type} is sleeping");
        }

        public virtual void Making_sound()
        {
            Console.WriteLine("making sound");
        }
       
            

        

    }
    public class Dog : Animal
    {
        public string furColor { get; set; }
        public Dog(int age, string eyeColor, int numberOfLegs, bool fur, string furcolor) : base(age, eyeColor, numberOfLegs, fur)
        {
            this.furColor = furcolor;
            this.type = "Dog";
        }
        public override void Making_sound()
        {
            Console.WriteLine($"WOOF WOOF!");
        }
        public void Walking()
        {
            Console.WriteLine($"the {type} is walking");
        }

    }
    public class Cat : Animal
    {
        public bool Domestic { get; set; }
        public Cat(int age, string eyeColor, int numberOfLegs, bool fur, bool domestic) : base(age, eyeColor, numberOfLegs, fur)
        {
            this.Domestic = domestic;
            this.type = "Cat";
        }
        public override void Making_sound()
        {
            Console.WriteLine("Mjau!");
        }
        public void Hunting()
        {
            Console.WriteLine($"the {type} is hunting!");
        }
    }
    public class Fish : Animal
    {
        public bool Freshwater { get; set; }
        public Fish(int age, string eyeColor, int numberOfLegs, bool fur, bool freshwater) : base(age, eyeColor, numberOfLegs, fur)
        {
            this.Freshwater = freshwater;
            this.type = "Fish";
        }
        public override void Making_sound()
        {
            Console.WriteLine("Blub!");
        }
        public void Swiming()
        {
            Console.WriteLine($"the {type} is swiming!");
        }
    }
    public class Shark : Fish
    {

        public int numberOfTeeth { get; set; }

        public Shark(int age, string eyeColor, int numberOfLegs, bool fur, bool freshwater, int teeth) : base(age, eyeColor, numberOfLegs, fur, freshwater)
        {
            this.type = "Shark";
            this.numberOfTeeth = teeth;
        }

        public void Sheed_teeth()
        {
            Console.WriteLine($"The {type} is sheeding it's teeth");
        }
    }
    public class Whale : Fish
    {
        public double weight { get; set; }
        public Whale(int age, string eyeColor, int numberOfLegs, bool fur,bool freshwater, double weight) : base(age, eyeColor, numberOfLegs, fur, freshwater)
        {
            this.weight = weight;
            this.type = "Whale";
        }

        public void Eco_location()
        {
            Console.WriteLine($"The {type} is orienting itself by making sounds ");
        }

  

    }

}
