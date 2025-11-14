using System;

namespace AnimalProject
{
    class Rabbit : IAnimal
    {
        public void Walk()
        {
            Console.WriteLine("Rabbit jumps quickly on the ground.");
        }

        public void Eat()
        {
            Console.WriteLine("Rabbit eats carrots and fresh leaves.");
        }

        public void Sleep()
        {
            Console.WriteLine("Rabbit sleeps in its soft burrow.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Rabbit makes a soft nose sound.");
        }
    }
}
