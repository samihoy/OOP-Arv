using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // fråga vill dom att man ska skriva in alla tributerna i klasen och ha två st constructors, en med sata värden och en med inmatade värden?
            
            Dog dog = new Dog(13,"blue", 4,true,"brown");
            Cat cat = new Cat(11,"green", 4, true, true);
            Fish fish = new Fish(4,"gold", 0, false,true);
            Shark shark = new Shark(44,"blue/white",0, false, false, 76);
            Whale whale = new Whale(200, "Blue", 0, false,false, 4000);

            dog.Making_sound();
            cat.Making_sound();
            fish.Making_sound();
            shark.Making_sound();
            whale.Making_sound();


        }
    }
}
