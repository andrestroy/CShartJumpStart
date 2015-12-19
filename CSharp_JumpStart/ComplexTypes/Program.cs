using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Felix";

            changeAnimalName(cat);
            Console.WriteLine("Cat's Name is:{0}", cat.Name);

            Dog dog = new Dog();
            dog.Name = "Ayudante de Santa";
            Console.WriteLine("Dog's Name is:{0}", dog.Name);
            changeDogName(dog);
            Console.WriteLine("Dog's Name now is:{0}", dog.Name);
            dog.MakeFunnySound(2, highest:true);
        }

        static void changeDogName(Dog dog)
        {
            dog.Name = "Snoopy";
        }

        static void changeAnimalName(Cat animal)
        {
            animal.Name = "Animal001";
        }
    }
}
