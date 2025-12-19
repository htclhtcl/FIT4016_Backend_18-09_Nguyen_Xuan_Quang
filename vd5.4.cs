using System;

namespace Inheritance
{
    // Lớp Animal (cha)
    class Animal
    {
        public string Name;

        public void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Lớp Dog (con) kế thừa Animal
    class Dog : Animal
    {
        public void MakeSoundNew()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Animal và Dog
            Animal a = new Animal();
            Dog d = new Dog();

            // Gọi MakeSound() của cả hai
            a.MakeSound();
            d.MakeSoundNew();
        }
    }
}
